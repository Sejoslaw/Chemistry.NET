/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Chemistry.NET.Tools.ElementStructureGenerator
{
    class Program
    {
        private const string Url = "https://pubchem.ncbi.nlm.nih.gov/rest/pug/periodictable/JSON/?response_type=display";

        private static Data Model { get; set; }

        static async Task Main(string[] args)
        {
            PrintRuntime();
            await RetrieveData();
            GenerateElementStructureFile();
        }

        static void PrintRuntime()
        {
            Console.WriteLine("==============================================================");
            Console.WriteLine("|    Chemistry.NET Element Structure Generator Tool v1.0     |");
            Console.WriteLine("|                                                            |");
            Console.WriteLine("|     Source: https://github.com/Sejoslaw/Chemistry.NET      |");
            Console.WriteLine("==============================================================");
        }

        static async Task RetrieveData()
        {
            var client = new HttpClient();
            var response = await client.GetStringAsync(Url);
            Model = JsonSerializer.Deserialize<Data>(response);
        }

        static void GenerateElementStructureFile()
        {
            var builder = new StringBuilder();

            builder.Append(@"/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Container for known Element Structures.
    /// </summary>
    public static class ElementStructures
    {" + Environment.NewLine);

            AppendElementStructure(builder);

            builder.Append(@"    }
}
");

            string fileContent = builder.ToString();
            File.Delete("ElementStructures.data");
            File.WriteAllText("ElementStructures.data", fileContent);
        }

        static void AppendElementStructure(StringBuilder builder)
        {
            var elementSymbols = Model.Table.Row.Select(r => r.Cell[1].ToLower()).ToList();
            var elementStructureBuilder = new ElementStructureBuilder(builder, elementSymbols);
            elementStructureBuilder.Build();
        }
    }
}
