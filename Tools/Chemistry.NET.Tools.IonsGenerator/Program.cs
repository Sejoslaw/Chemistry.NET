using System;
using System.IO;
using System.Text;

namespace Chemistry.NET.Tools.IonsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRuntime();
            GenerateIonsFile();
        }
        
        static void PrintRuntime()
        {
            Console.WriteLine("=====================================================");
            Console.WriteLine("|      Chemistry.NET Ions Generator Tool v1.0       |");
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Source: https://github.com/Sejoslaw/Chemistry.NET |");
            Console.WriteLine("=====================================================");
        }

        static void GenerateIonsFile()
        {
            var builder = new StringBuilder();

            builder.Append(@"/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Ions.Models
{
    /// <summary>
    /// Container for known Element Structures.
    /// </summary>
    public static class CommonIons
    {" + Environment.NewLine);

            new CommonIonsGenerator(builder).Build();

            builder.Append(@"    }
}
");

            string fileContent = builder.ToString();
            File.Delete("CommonIons.data");
            File.WriteAllText("CommonIons.data", fileContent);
        }
    }
}
