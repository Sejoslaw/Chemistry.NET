/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Chemistry.NET.Tools.IsotopesGenerator
{
    public static class SingleRowParser
    {
        public static string Parse(string elementName, IReadOnlyList<string> fields, Func<IReadOnlyList<string>, string> func = null)
        {
            func ??= GetPropertyName;
            
            var row = $"public static Isotope { func(fields) } ";
            row += "{ get; } = new Isotope(";

            row += $"Elements.{ elementName }, "; // Element
            row += $"\"{ CleanFromLegendReference(fields[0]) }\", "; // Nuclide
            
            var index = 1;
            row += HandleNumbersAndMass(fields, ref index); // AtomicNumber, NeutronCount, IsotopicMass
            row += HandleIfStable(fields, ref index); // Halflife, Decay, DaughterIsotope
            row += HandleSpinAndPurity(fields, index); // Spin, Purity
            
            row += ");";
            row += Environment.NewLine;

            return row;
        }
        
        public static string GetPropertyName(IReadOnlyList<string> fields)
        {
            var propValue = CleanFromLegendReference(fields[0]);
            propValue = propValue.Replace(" ", "");
            var firstCharIndex = 0;

            for (var i = 0; i < propValue.Length; ++i)
            {
                if (char.IsNumber(propValue[i]))
                {
                    continue;
                }
                
                firstCharIndex = i;
                break;
            }

            return char.ToUpper(propValue[firstCharIndex]) + propValue.Substring(firstCharIndex + 1) + propValue.Substring(0, firstCharIndex);
        }

        private static string HandleNumbersAndMass(IReadOnlyList<string> fields, ref int index)
        {
            const string massEnding = " keV";
            var atomicNumber = fields[index];
            var neutronCount = "";
            var isotopicMass = "";
            
            if (atomicNumber.Contains(massEnding))
            {
                atomicNumber = "";
                isotopicMass = fields[index];
                index++;
            }
            else if (atomicNumber.Trim().Equals(""))
            {
                atomicNumber = "";
                index++;
            }
            else
            {
                neutronCount = fields[index + 1];
                isotopicMass = fields[index + 2];
                index += 3;
            }

            isotopicMass = isotopicMass.Replace(massEnding, "");
            
            return $"\"{ CleanFromLegendReference(atomicNumber) }\", \"{ CleanFromLegendReference(neutronCount) }\", \"{ CleanFromLegendReference(isotopicMass) }\", ";
        }
        
        private static string HandleIfStable(IReadOnlyList<string> fields, ref int index)
        {
            var halflife = fields[index];
            var decay = "";
            var daughterIsotope = "";
            
            if (int.TryParse(halflife?.FirstOrDefault().ToString(), out int value2) && 
                fields.Count == 6 &&
                index == 4)
            {
                decay = fields[^3];
                daughterIsotope = fields[^2];
                index++;
            }
            else if (int.TryParse(halflife?.FirstOrDefault().ToString(), out int value))
            {
                decay = fields[index + 1];
                daughterIsotope = fields[index + 2];
                index += 3;
            }
            else
            {
                index++;
            }

            return $"\"{ CleanFromLegendReference(halflife) }\", \"{ CleanFromLegendReference(decay) }\", \"{ CleanFromLegendReference(daughterIsotope) }\", ";
        }
        
        private static string HandleSpinAndPurity(IReadOnlyList<string> fields, int index)
        {
            var spin = fields[index];
            var parity = fields[index];
            
            return $"\"{ CleanFromLegendReference(spin) }\", \"{ CleanFromLegendReference(parity) }\"";
        }

        private static string CleanFromLegendReference(string text)
        {
            string[] invalidChars = { "[", "(" };
            
            text = text.Replace(Environment.NewLine, "").Replace("\"", "");

            foreach (var invalidChar in invalidChars)
            {
                if (!text.Contains(invalidChar))
                {
                    continue;
                }
                
                var indexOf = text.IndexOf(invalidChar, StringComparison.Ordinal);
                text = text.Substring(0, indexOf);
            }

            return text;
        }
    }
}
