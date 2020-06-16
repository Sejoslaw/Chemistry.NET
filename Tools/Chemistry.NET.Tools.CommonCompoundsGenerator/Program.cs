/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.IO;
using System.Text;

namespace Chemistry.NET.Tools.CommonCompoundsGenerator
{
    class Program
    {
        public const string FileName = "CommonCompounds.data";
        
        static void Main(string[] args)
        {
            PrintRuntime();
            GenerateCommonCompoundsFile();
        }

        private static void PrintRuntime()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("|    Chemistry.NET Common Compounds Generator Tool v1.0    |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|    Source: https://github.com/Sejoslaw/Chemistry.NET     |");
            Console.WriteLine("============================================================");
        }

        private static void GenerateCommonCompoundsFile()
        {
            using (var stream = File.Create(FileName))
            {
                stream.Flush();
                stream.Close();
            }
            
            var builder = new StringBuilder();

            builder.Append(@"/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Compounds
{
    /// <summary>
    /// Container for some of the most common Chemical Compounds.
    /// </summary>
    public static class CommonCompounds
    {" + Environment.NewLine);

            new CommonCompoundsBuilder(builder).Build();

            builder.Append(@"    }
}
");

            var fileContent = builder.ToString();
            File.AppendAllText(FileName, fileContent);
        }
    }
}
