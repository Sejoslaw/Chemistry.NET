/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Common;
using Chemistry.NET.Tools.Common;
using Chemistry.NET.Tools.Common.Models;
using OpenQA.Selenium;

namespace Chemistry.NET.Tools.IsotopesGenerator
{
    internal class IsotopesGeneratorToolRunner : GeneratorToolRunner
    {
        public override void PrintRuntime()
        {
            Console.WriteLine("====================================================="); 
            Console.WriteLine("|    Chemistry.NET Isotopes Generator Tool v1.1     |"); 
            Console.WriteLine("|                                                   |");
            Console.WriteLine("| Source: https://github.com/Sejoslaw/Chemistry.NET |");
            Console.WriteLine("=====================================================");
        }

        public override GeneratorConfigurationModel GetConfiguration()
        {
            return new GeneratorConfigurationModel
            {
                Namespace = "Chemistry.NET.Elements.Models",
                ClassComment = "Container for known Isotopes.",
                ClassName = "CommonIsotopes",
                FileName = "Isotopes"
            };
        }

        public override IEnumerable<string> GetLines(IWebDriver driver)
        {
            var list = new List<string>();
            
            Container
                .Elements
                .Select(e => e.Name)
                .ToList()
                .ForEach(elementName => Build(list, driver, elementName));

            return list;
        }

        private static void Build(List<string> list, IWebDriver driver, string elementName)
        {
            list.Add("");
            list.Add($"/// { elementName }");
            list.Add("");
            
            var url = "https://en.wikipedia.org/wiki/Isotopes_of_" + elementName.ToLower();
            driver.Navigate().GoToUrl(url);

            var rowsElements = new List<IWebElement>();
            var rowId = 1;

            try
            {
                do
                {
                    var element = driver.FindElement(By.CssSelector($"#mw-content-text > div > table.wikitable > tbody > tr:nth-child({ rowId })"));
                    rowsElements.Add(element);
                    rowId++;
                }
                while (true);
            }
            catch { } // Exception will be thrown when rowId will get out of bounds

            var rows = rowsElements.Select(row => row.FindElements(By.XPath("td")).ToList()).ToList();

            for (var rowNumber = 0; rowNumber < rows.Count; ++rowNumber)
            {
                var fields = rows[rowNumber];
                var fieldValues = fields.Select(we => we.Text).ToList();

                // Skip header
                if (fieldValues.Count == 0)
                {
                    continue;
                }
                
                // Skip some weird cases
                if (fieldValues.Count > 2 && 
                    (fieldValues[2].Equals("Reaction yet to be attempted") || 
                     fieldValues[2].Equals("Planned reaction") ||
                     fieldValues[2].Equals("Successful reaction") ||
                     fieldValues[2].Equals("Failure to date")))
                {
                    continue;
                }

                // Some rows in table are weirdly interpreted by Selenium
                // We need at least 4 fields to properly parse
                if (fieldValues.Count < 4)
                {
                    // We need to move 1 up but because we do "++rowNumber", we need to move 2 up
                    rowNumber -= 2;
                    continue;
                }
                
                var rowSpan = MultiRowParser.GetRowspan(fields);

                if (rowSpan > 0)
                {
                    var toAppend = MultiRowParser.Parse(elementName, rows, fields, fieldValues, rowNumber, rowSpan);
                    list.AddRange(toAppend);
                    rowNumber += rowSpan - 1;
                }
                else
                {
                    var toAppend = SingleRowParser.Parse(elementName, fieldValues);
                    list.Add(toAppend);
                }
            }
        }
    }
}
