/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;

namespace Chemistry.NET.Tools.IsotopesGenerator
{
    public static class MultiRowParser
    {
        private const string Rowspan = "rowspan";
        
        public static List<string> Parse(string elementName, List<List<IWebElement>> rows, IEnumerable<IWebElement> fields, IReadOnlyList<string> fieldValues, in int rowIndex, in int rowSpan)
        {
            var fieldsWithRowspan = GetFieldsWithRowspan(fields);
            var parsed = new List<string> { SingleRowParser.Parse(elementName, fieldValues) };

            for (var i = 1; i < rowSpan; ++i)
            {
                var lastCheckedCurrentRowIndex = 0;
                var currentRowIndex = rowIndex + i;
                var currentRow = rows[currentRowIndex];

                var currentFields = new List<string>();

                for (var j = 0; j < fieldValues.Count; ++j)
                {
                    var toAdd = "";

                    if (fieldsWithRowspan[j])
                    {
                        toAdd = fieldValues[j];
                    }
                    else
                    {
                        var text = lastCheckedCurrentRowIndex < currentRow.Count ? currentRow[lastCheckedCurrentRowIndex].Text : rows[currentRowIndex - 1][lastCheckedCurrentRowIndex].Text;
                        lastCheckedCurrentRowIndex++;
                        toAdd = text;
                    }
                    
                    currentFields.Add(toAdd);
                }

                var propName = GetPropertyName(currentFields, i);
                var parsedRow = SingleRowParser.Parse(elementName, currentFields, (readOnlyList) => propName);
                parsed.Add(parsedRow);
            }

            return parsed;
        }

        private static string GetPropertyName(IReadOnlyList<string> currentFields, int index)
        {
            var propName = SingleRowParser.GetPropertyName(currentFields);
            return propName + "_" + index;
        }

        private static IReadOnlyList<bool> GetFieldsWithRowspan(IEnumerable<IWebElement> fields)
        {
            return fields.Select(f => int.TryParse(f.GetAttribute(Rowspan), out var value) && value > 1).ToList();
        }

        public static int GetRowspan(IEnumerable<IWebElement> fields)
        {
            foreach (var field in fields)
            {
                if (int.TryParse(field.GetAttribute(Rowspan), out var value) && value > 0)
                {
                    return value;
                }
            }

            return 0;
        }
    }
}
