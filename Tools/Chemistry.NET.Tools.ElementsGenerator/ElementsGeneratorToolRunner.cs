/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Chemistry.NET.Tools.Common;
using Chemistry.NET.Tools.Common.Models;
using OpenQA.Selenium;

namespace Chemistry.NET.Tools.ElementsGenerator
{
    public class ElementsGeneratorToolRunner : GeneratorToolRunner
    {
        private Data Model { get; set; }
        
        private readonly IDictionary<string, string> ElectronConfigurations = new Dictionary<string, string>
        {
            { "[He]", "1s2 " },
            { "[Ne]", "1s2 2s2 2p6 " },
            { "[Ar]", "1s2 2s2 2p6 3s2 3p6 " },
            { "[Kr]", "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 " },
            { "[Xe]", "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 " },
            { "[Rn]", "1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 " },
        };
        
        public override void PrintRuntime()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|    Chemistry.NET Elements Generator Tool v1.1     |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Source: https://github.com/Sejoslaw/Chemistry.NET |");
            Console.WriteLine("=====================================================");
        }

        public override async Task RetrieveData(HttpClient client)
        {
            var response = await client.GetStringAsync("https://pubchem.ncbi.nlm.nih.gov/rest/pug/periodictable/JSON/?response_type=display");
            Model = JsonSerializer.Deserialize<Data>(response);
        }

        public override GeneratorConfigurationModel GetConfiguration()
        {
            return new GeneratorConfigurationModel
            {
                Namespace = "Chemistry.NET.Elements.Models",
                ClassComment = "Container for known Elements.",
                ClassName = "CommonElements",
                FileName = "Elements"
            };
        }

        public override IEnumerable<string> GetLines(IWebDriver driver)
        {
            var elements = Model.Table.Row;

            return elements
                .Select(element => element.Cell)
                .Select(PrepareLine)
                .ToList();
        }
        
        private string PrepareLine(IReadOnlyList<string> data)
        {
            var row = "public static Element " + data[2] + " { get; } = new Element(";
        
            row += GetNumber(data, 0);
            row += GetValue(data, 1);
            row += GetValue(data, 2);
        
            row += GetNumber(data, 3);
            row += GetValue(data, 4);
            row += GetElementElectronConfiguration(data, 5);
        
            row += GetValue(data, 6);
            row += GetValue(data, 7);
            row += GetValue(data, 8);
        
            row += GetValue(data, 9);
            row += GetValue(data, 10);
            row += GetEnum(data, 11, "PhysicalStates");
        
            row += GetValue(data, 12);
            row += GetValue(data, 13);
            row += GetValue(data, 14);
        
            row += GetEnum(data, 15, "ElementTypes");
            row += GetNumber(data, 16);
            row += GetElementStructure(data);
        
            row += ");";
        
            return row;
        }
        
        private static string GetElementStructure(IReadOnlyList<string> data)
        {
            return $"ElementStructures.{ data[2] }";
        }
        
        private string GetElementElectronConfiguration(IReadOnlyList<string> data, int i)
        {
            var line = "new ElectronConfiguration(\"";
        
            var config = data[i];
            
            foreach(var (key, value) in ElectronConfigurations)
            {
                if (!config.Contains(key))
                {
                    continue;
                }
                    
                config = config.Replace(key, value);
                break;
            }
        
            config = config.Replace(" (calculated)", "").Replace(" (predicted)", "").Replace("  ", " ");
        
            line += config;
            line += "\"), ";
        
            return line;
        }
        
        private static string GetNumber(IReadOnlyList<string> data, int i, bool addComma = true)
        {
            var value = data[i];
        
            if (double.TryParse(value, out var val))
            {
                value = val.ToString(CultureInfo.InvariantCulture);
            }
        
            if (value.Equals("Ancient"))
            {
                value = int.MinValue.ToString();
            }
        
            if (addComma)
            {
                value += ", ";
            }
        
            return value;
        }
        
        private static string GetValue(IReadOnlyList<string> data, int i)
        {
            var value = data[i];
            var parsed = string.IsNullOrWhiteSpace(value) ? "\"\", " : $"\"{ value }\", ";
            
            return parsed;
        }
        
        private static string GetEnum(IReadOnlyList<string> data, int i, string prefix)
        {
            var value = data[i];
            var chars = value.ToList();
            
            var modifiedChars = chars
                .Select((symbol, index) => (index > 0 && (chars[index - 1] == ' ' || chars[index - 1] == '-') ? char.ToUpper(symbol) : symbol))
                .Where(symbol => symbol != ' ' && symbol != '-')
                .ToArray();
            
            var modified = new string(modifiedChars);
           
            return $"{ prefix }.{ modified }, ";
        }
    }
}
