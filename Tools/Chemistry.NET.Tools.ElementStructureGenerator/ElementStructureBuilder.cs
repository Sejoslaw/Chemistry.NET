/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Chemistry.NET.Tools.ElementStructureGenerator
{
    internal class ElementStructureBuilder
    {
        public const string Space = "    ";

        public StringBuilder Builder { get; }
        public IEnumerable<string> ElementSymbols { get; }

        /// <summary>
        /// TODO: Add missing valence electron information.
        /// </summary>
        private IDictionary<string, int> ValenceElectrons { get; } = new Dictionary<string, int>()
        {
            {"Cesium", 8},
            {"Aluminum", 3},
            {"Palladium", 10},
            {"Rutherfordium", 4},
            {"Dubnium", 5},
            {"Seaborgium", 6},
            {"Bohrium", 7},
            {"Hassium", 0}, // N/A
            {"Meitnerium", 0}, // N/A
            {"Darmstadtium", 0}, // N/A
            {"Roentgenium", 0}, // N/A
            {"Copernicium", 0}, // N/A
            {"Nihonium", 0}, // N/A
            {"Flerovium", 0}, // N/A
            {"Moscovium", 0}, // N/A
            {"Livermorium", 0}, // N/A
            {"Tennessine", 0}, // N/A
            {"Oganesson", 0}, // N/A
        };

        public ElementStructureBuilder(StringBuilder builder, IEnumerable<string> elementSymbols)
        {
            Builder = builder;
            ElementSymbols = elementSymbols;
        }

        internal void Build()
        {
            var options = new ChromeOptions();
            options.AddArgument("incognito");

            using (IWebDriver driver = new ChromeDriver(options))
            {
                GatherValenceElectrons(driver);

                foreach (string elementSymbol in ElementSymbols)
                {
                    try
                    {
                        Build(driver, elementSymbol);
                    }
                    catch
                    {
                        Console.WriteLine($"---=== Error when processing Element ===---");
                        Console.WriteLine($"Element Symbol: { elementSymbol }");
                    }
                }
                
                BuildMissing();
            }
        }

        private void BuildMissing()
        {
            IEnumerable<string> missingElements = new List<string>
                {
                    "public static ElementStructure Darmstadtium { get; } = new ElementStructure(\"Darmstadtium\", 110, 110, 151, 0);", 
                    "public static ElementStructure Roentgenium { get; } = new ElementStructure(\"Roentgenium\", 111, 111, 161, 0);", 
                    "public static ElementStructure Copernicium { get; } = new ElementStructure(\"Copernicium\", 112, 112, 173, 0);", 
                    "public static ElementStructure Nihonium { get; } = new ElementStructure(\"Nihonium\", 113, 113, 173, 0);", 
                    "public static ElementStructure Flerovium { get; } = new ElementStructure(\"Flerovium\", 114, 114, 175, 0);", 
                    "public static ElementStructure Moscovium { get; } = new ElementStructure(\"Moscovium\", 115, 115, 174, 0);", 
                    "public static ElementStructure Livermorium { get; } = new ElementStructure(\"Livermorium\", 116, 116, 177, 0);", 
                    "public static ElementStructure Tennessine { get; } = new ElementStructure(\"Tennessine\", 117, 117, 177, 0);", 
                    "public static ElementStructure Oganesson { get; } = new ElementStructure(\"Oganesson\", 118, 118, 176, 0);"
                };

            foreach (var missingElement in missingElements)
            {
                Builder.Append(Space + Space + missingElement + Environment.NewLine);
            }
        }

        private void GatherValenceElectrons(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/List_of_elements_by_atomic_properties");

            var table = driver.FindElement(By.ClassName("sortable"));
            var rows = table.FindElements(By.TagName("tr"));

            for (var i = 2; i < rows.Count; ++i)
            {
                var fields = rows[i].FindElements(By.TagName("td"));
                var elementName = fields[1].Text;
                var valenceElectronsCount = "";

                try
                {
                    valenceElectronsCount = fields[9].Text;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }

                if (!string.IsNullOrWhiteSpace(valenceElectronsCount))
                {
                    ValenceElectrons.Add(elementName, int.Parse(valenceElectronsCount));
                }
            }
        }

        private void Build(IWebDriver driver, string elementSymbol)
        {
            driver.Navigate().GoToUrl($"http://www.chemicalelements.com/elements/{ elementSymbol }.html");

            var elementName = GetValueFromNode(driver, "/html/body/table/tbody/tr/td[3]/font/strong[1]");
            var protonsCount = GetValueFromNode(driver, "/html/body/table/tbody/tr/td[3]/font/strong[7]");
            var electronsCount = protonsCount;
            var neutronsCount = GetValueFromNode(driver, "/html/body/table/tbody/tr/td[3]/font/strong[8]");
            var valenceNeutronsCount = 0;

            try
            {
                valenceNeutronsCount = ValenceElectrons[elementName];
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Builder.Append(
                Space + Space + 
                $"public static ElementStructure { elementName } " + 
                "{ get; } = " + 
                $"new ElementStructure(\"{ elementName }\", { protonsCount }, { electronsCount }, { neutronsCount }, { valenceNeutronsCount });" + 
                Environment.NewLine);
        }

        private string GetValueFromNode(IWebDriver driver, string node)
        {
            return ((IJavaScriptExecutor)driver)
                    .ExecuteScript($"return document.evaluate(\"{ node }\", document, null, XPathResult.FIRST_ORDERED_NODE_TYPE, null).singleNodeValue.nextSibling.nodeValue")
                    .ToString()
                    .Replace(" ", "")
                    .Replace(Environment.NewLine, "");
        }
    }
}
