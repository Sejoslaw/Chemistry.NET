/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Chemistry.NET.Tools.IsotopesGenerator
{
    internal class IsotopeBuilder
    {
        private const string Space = "    ";
        
        private StringBuilder Builder { get; }
        private IEnumerable<string> ElementNames { get; }

        public IsotopeBuilder(StringBuilder builder, IEnumerable<string> elementNames)
        {
            Builder = builder;
            ElementNames = elementNames;
        }

        internal void Build()
        {
            var options = new ChromeOptions();
            options.AddArgument("incognito");

            using IWebDriver driver = new ChromeDriver(options);
            foreach (var elementName in ElementNames)
            {
                Builder.Append(Environment.NewLine);
                Builder.Append(Space + Space + $"// { elementName }" + Environment.NewLine);
                Builder.Append(Environment.NewLine);
                Build(driver, elementName);
            }
        }

        private void Build(IWebDriver driver, string elementName)
        {
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
                    toAppend.ForEach(parsedRow => Builder.Append(Space + Space + parsedRow));
                    rowNumber += rowSpan;
                }
                else
                {
                    var toAppend = SingleRowParser.Parse(elementName, fieldValues);
                    Builder.Append(Space + Space + toAppend);
                }
            }
        }
    }
}
