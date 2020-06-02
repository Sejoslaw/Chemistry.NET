using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chemistry.NET.Tools.ElementsGenerator
{
    class Program
    {
        private const string Url = "https://pubchem.ncbi.nlm.nih.gov/rest/pug/periodictable/JSON/?response_type=display";

        private static Data Model { get; set; }

        static async Task Main(string[] args)
        {
            PrintRuntime();
            await RetrieveData();
            GenerateElementsFile();
        }

        static void PrintRuntime()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|    Chemistry.NET Elements Generator Tool v1.0     |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Source: https://github.com/Sejoslaw/Chemistry.NET |");
            Console.WriteLine("=====================================================");
        }

        static async Task RetrieveData()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync(Url);
            Model = JsonSerializer.Deserialize<Data>(response);
        }

        static void GenerateElementsFile()
        {
            var builder = new StringBuilder();

            builder.Append(@"/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Container for known Elements.
    /// </summary>
    public static class Elements
    {" + Environment.NewLine);

            AppendElements(builder);

            builder.Append(@"    }
}
");

            string fileContent = builder.ToString();
            File.Delete("Elements");
            File.WriteAllText("Elements", fileContent);
        }

        static void AppendElements(StringBuilder builder)
        {
            var space = "        ";
            var elements = Model.Table.Row;

            foreach(var element in elements)
            {
                string[] data = element.Cell;
                string row = space;
                string line = PrepareLine(row, data, builder);
                builder.Append(line);
            }
        }

        static string PrepareLine(string row, string[] data, StringBuilder builder)
        {
            row += $"public static Element { data[2] } = new Element(";

            row += GetNumber(data, 0);
            row += GetValue(data, 1);
            row += GetValue(data, 2);

            row += GetNumber(data, 3);
            row += GetValue(data, 4);
            row += GetValue(data, 5);

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
            row += GetNumber(data, 16, false);

            row += ");" + Environment.NewLine;

            return row;
        }

        private static string GetNumber(string[] data, int i, bool addComma = true)
        {
            var value = data[i];

            if (double.TryParse(value, out double val))
            {
                value = val.ToString();
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

        static string GetEnum(string[] data, int i, string prefix)
        {
            string value = data[i];
            var chars = value.ToList();
            char[] modifiedChars = chars
                .Select((symbol, index) => (index > 0 && (chars[index - 1] == ' ' || chars[index - 1] == '-') ? char.ToUpper(symbol) : symbol))
                .Where(symbol => symbol != ' ' && symbol != '-')
                .ToArray();
            string modified = new string(modifiedChars);
            return $"{ prefix }.{ modified }, ";
        }

        static string GetValue(string[] data, int i)
        {
            var value = data[i];
            var parsed = string.IsNullOrWhiteSpace(value) ? "\"\", " : $"\"{ value }\", ";
            return parsed;
        }
    }
}
