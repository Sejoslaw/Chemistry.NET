/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chemistry.NET.Tools.Common;
using Chemistry.NET.Tools.Common.Models;
using OpenQA.Selenium;

namespace Chemistry.NET.Tools.CommonCompoundsGenerator
{
    /// <summary>
    /// TODO: There are missing few tweaks but only 4 records do not parse correctly and it can be fixed by hand easily...
    /// </summary>
    public class CommonCompoundsGeneratorToolRunner : GeneratorToolRunner
    {
        private ICollection<string> PropertyNames { get; } = new List<string>();
        
        public override void PrintRuntime()
        {
            Console.WriteLine("============================================================");
            Console.WriteLine("|    Chemistry.NET Common Compounds Generator Tool v1.1    |");
            Console.WriteLine("|                                                          |");
            Console.WriteLine("|    Source: https://github.com/Sejoslaw/Chemistry.NET     |");
            Console.WriteLine("============================================================");
        }

        public override GeneratorConfigurationModel GetConfiguration()
        {
            return new GeneratorConfigurationModel
            {
                Namespace = "Chemistry.NET.Compounds.Models",
                ClassComment = "Container for some of the most common Chemical Compounds.",
                ClassName = "CommonCompounds",
                FileName = "CommonCompounds"
            };
        }

        public override IEnumerable<string> GetLines(IWebDriver driver)
        {
            var list = new List<string>();
            
            driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/Glossary_of_chemical_formulae");

            var tables = driver.FindElements(By.ClassName("wikitable"));

            foreach (var table in tables)
            {
                var rows = table.FindElements(By.TagName("tr"));

                for (var rowId = 0; rowId < rows.Count; ++rowId)
                {
                    var fields = rows[rowId].FindElements(By.TagName("td"));

                    if (fields.Count < 2)
                    {
                        continue;
                    }

                    if (int.TryParse(fields[0].GetAttribute("rowspan"), out var rowSpan) && rowSpan > 1)
                    {
                        HandleMultirow(list, rows, fields, rowId, rowSpan);
                        rowId = rowId + rowSpan - 1;
                    }
                    else
                    {
                        list.Add(PrepareRow(fields[0].Text, fields[1]));
                    }
                }
            }

            return list;
        }

        private void HandleMultirow(List<string> list, IReadOnlyList<IWebElement> rows, IReadOnlyList<IWebElement> fields, in int rowId, in int rowSpan)
        {
            list.Add(PrepareRow(fields[0].Text, fields[1]));

            var chemicalFormula = fields[0];
            
            for (var index = rowId + 1; index < rowId + rowSpan; ++index)
            {
                var row = rows[index].FindElements(By.TagName("td"));
                var newFields = new List<IWebElement> { chemicalFormula, row[0] };
                
                list.Add(PrepareRow(newFields[0].Text, newFields[1]));
            }
        }

        private string PrepareRow(string chemicalFormula, IWebElement compoundNameField)
        {
            var chosenCompoundName = ChooseAppropriateCompoundName(compoundNameField);
            var compoundName = CleanCompoundName(chosenCompoundName);
            var propertyName = ParsePropertyName(CleanPropertyName(compoundName));
            
            return $"public static ChemicalCompound { propertyName } " + "{ get; } = " + $"ChemicalCompound.New(\"{ chemicalFormula }\", \"{ compoundName }\");";
        }

        private string ParsePropertyName(string propertyName)
        {
            var similarPropNames = PropertyNames.Count(str => str.Split("_")[0].Equals(propertyName));

            if (similarPropNames > 0)
            {
                propertyName += "_" + similarPropNames;
            }

            PropertyNames.Add(propertyName);

            return propertyName;
        }

        private static string ChooseAppropriateCompoundName(IWebElement field)
        {
            var children = field.FindElements(By.XPath(".//*"));

            switch (children.Count)
            {
                case 0:
                    return field.Text;
                case 1:
                    return children[0].Text;
                default:
                {
                    var text = children
                        .Select(node => node.Text)
                        .Where(str => !string.IsNullOrWhiteSpace(str))
                        .OrderByDescending(str => str.Length)
                        .FirstOrDefault();

                    return text;
                }
            }
        }

        private static string CleanPropertyName(string str)
        {
            str = str.Replace(",", " ").Replace("-", " ");

            if (char.IsNumber(str[0]))
            {
                str = CleanCompoundName(str);
            }
            
            str = str.Replace("(I)", "1").Replace("(II)", "2").Replace("(III)", "3")
                .Replace("(IV)", "4").Replace("(V)", "5").Replace("(VI)", "6")
                .Replace("(VII)", "7").Replace("(IIIII)", "5").Replace("(tri)", "3");

            str = str.Replace("1", "One").Replace("2", "Two").Replace("3", "Three")
                .Replace("4", "Four").Replace("5", "Five").Replace("6", "Six")
                .Replace("7", "Seven").Replace("8", "Right").Replace("9", "Nine");

            str = str.Replace(" ", "");

            return str;
        }

        private static string CleanCompoundName(string str)
        {
            // Replace letter after space to be upper
            str = new string(str.Select((ch, i) =>
            {
                if ((i == 0) || char.IsWhiteSpace(str[i - 1]))
                {
                    return char.ToUpper(ch);
                }

                return ch;
            }).ToArray());

            return str;
        }
    }
}
