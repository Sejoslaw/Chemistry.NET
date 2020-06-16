/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Chemistry.NET.Tools.CommonCompoundsGenerator
{
    /// <summary>
    /// TODO: There are missing few tweaks but only 4 records do not parse correctly and it can be fixed by hand easily...
    /// </summary>
    public class CommonCompoundsBuilder
    {
        private const string Space = "    ";

        private StringBuilder Builder { get; }
        private ICollection<string> PropertyNames { get; } = new List<string>();

        public CommonCompoundsBuilder(StringBuilder builder)
        {
            Builder = builder;
        }

        public void Build()
        {
            var options = new ChromeOptions();
            options.AddArgument("incognito");

            using IWebDriver driver = new ChromeDriver(options);
            Build(driver);
        }

        private void Build(IWebDriver driver)
        {
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
                        HandleMultirow(rows, fields, rowId, rowSpan);
                        rowId = rowId + rowSpan - 1;
                    }
                    else
                    {
                        AppendRow(fields);
                    }
                }
                
                File.AppendAllText(Program.FileName, Builder.ToString());
                Builder.Clear();
            }
        }

        private void HandleMultirow(IReadOnlyList<IWebElement> rows, IReadOnlyList<IWebElement> fields, in int rowId, in int rowSpan)
        {
            AppendRow(fields);

            var chemicalFormula = fields[0];
            
            for (var index = rowId + 1; index < rowId + rowSpan; ++index)
            {
                var row = rows[index].FindElements(By.TagName("td"));
                var newFields = new List<IWebElement> { chemicalFormula, row[0] };
                
                AppendRow(newFields);
            }
        }

        private void AppendRow(IReadOnlyList<IWebElement> fields)
        {
            var parsedRow = PrepareRow(fields[0].Text, fields[1]);
            Builder.Append(Space + Space + parsedRow + Environment.NewLine);
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

        private string ChooseAppropriateCompoundName(IWebElement field)
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

        private string CleanPropertyName(string str)
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

        private string CleanCompoundName(string str)
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
