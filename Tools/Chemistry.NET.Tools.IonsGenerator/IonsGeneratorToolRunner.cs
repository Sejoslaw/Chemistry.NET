/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using Chemistry.NET.Tools.Common;
using Chemistry.NET.Tools.Common.Models;
using OpenQA.Selenium;

namespace Chemistry.NET.Tools.IonsGenerator
{
    public class IonsGeneratorToolRunner : GeneratorToolRunner
    {
        public override void PrintRuntime()
        {
            Console.WriteLine("=======================================================");
            Console.WriteLine("|       Chemistry.NET Ions Generator Tool v1.0        |");
            Console.WriteLine("|                                                     |");
            Console.WriteLine("|  Source: https://github.com/Sejoslaw/Chemistry.NET  |");
            Console.WriteLine("=======================================================");
        }

        public override GeneratorConfigurationModel GetConfiguration()
        {
            return new GeneratorConfigurationModel
            {
                Namespace = "Chemistry.NET.Ions.Models",
                ClassComment = "Container for oxidation states of the known Elements.",
                ClassName = "CommonIons",
                FileName = "Ions"
            };
        }

        public override IEnumerable<string> GetLines(IWebDriver driver)
        {
            var list = new List<string>();
            
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Oxidation_state#List_of_oxidation_states_of_the_elements");

            var table = driver.FindElements(By.ClassName("sortable"))[0];
            var rows = table.FindElement(By.TagName("tbody")).FindElements(By.TagName("tr"));

            foreach (var row in rows)
            {
                var fields = row.FindElements(By.TagName("td"));

                var elementName = char.ToUpper(fields[1].Text[0]) + fields[1].Text.Substring(1);

                for (var i = 3; i < 18; ++i)
                {
                    if (string.IsNullOrWhiteSpace(fields[i].Text))
                    {
                        continue;
                    }

                    var state = fields[i].Text;
                    var modifiedState = state.Replace("−", "Minus").Replace("+", "Plus");

                    var propertyLine =
                        $"public static Ion { elementName + modifiedState } " +
                        "{ get; } = new Ion(" + 
                        $"CommonElements.{ elementName }, { state.Replace("−", "-") });";
                    
                    list.Add(propertyLine);
                }
            }

            return list;
        }
    }
}
