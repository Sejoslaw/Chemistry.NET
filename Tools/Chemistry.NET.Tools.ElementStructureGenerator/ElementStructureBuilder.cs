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
            }
        }

        private void Build(IWebDriver driver, string elementSymbol)
        {
            driver.Navigate().GoToUrl($"http://www.chemicalelements.com/elements/{ elementSymbol }.html");

            var elementName = GetValueFromNode(driver, "/html/body/table/tbody/tr/td[3]/font/strong[1]");
            var protonsCount = GetValueFromNode(driver, "/html/body/table/tbody/tr/td[3]/font/strong[7]");
            var electronsCount = protonsCount;
            var neutronsCount = GetValueFromNode(driver, "/html/body/table/tbody/tr/td[3]/font/strong[8]");

            Builder.Append(
                Space + Space + 
                $"public static ElementStructure { elementName } " + 
                "{ get; } = " + 
                $"new ElementStructure(\"{ elementName }\", { protonsCount }, { electronsCount }, { neutronsCount });" + 
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
