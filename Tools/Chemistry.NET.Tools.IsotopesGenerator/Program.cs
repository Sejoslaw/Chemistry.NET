/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.IO;
using System.Linq;
using System.Text;
using Chemistry.NET.Models;

namespace Chemistry.NET.Tools.IsotopesGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRuntime();
            GenerateIsotopesFile();
        }

        static void PrintRuntime()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|    Chemistry.NET Isotopes Generator Tool v1.0     |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Source: https://github.com/Sejoslaw/Chemistry.NET |");
            Console.WriteLine("=====================================================");
        }

        static void GenerateIsotopesFile()
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
    /// Container for known Isotopes.
    /// </summary>
    public static class Isotopes
    {" + Environment.NewLine);

            AppendIsotopes(builder);

            builder.Append(@"    }
}
");

            string fileContent = builder.ToString();
            File.Delete("Isotopes.data");
            File.WriteAllText("Isotopes.data", fileContent);
        }

        static void AppendIsotopes(StringBuilder builder)
        {
            var elements = Container.Elements.Select(e => e.Name).ToList();
            var isotopeBuilder = new IsotopeBuilder(builder, elements);
            isotopeBuilder.Build();
        }
    }
}
