/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Compounds.Parsers.ChemicalCompounds;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Compounds.Models
{
    /// <summary>
    /// Represents the core Chemical Compound.
    /// </summary>
    public partial class ChemicalCompound
    {
        public int GetTotalElectronsCount()
        {
            return GetTotalCount(e => e.Structure.ElectronsCount);
        }

        public int GetTotalProtonsCount()
        {
            return GetTotalCount(e => e.Structure.ProtonsCount);
        }

        public int GetTotalNeutronsCount()
        {
            return GetTotalCount(e => e.Structure.NeutronsCount);
        }

        private int GetTotalCount(Func<Element, int> func)
        {
            var total = 0;

            foreach (var node in StructureTree)
            {
                if (node is ElementStack elementStack)
                {
                    total += func(elementStack.Element) * elementStack.Count;
                }
                else if (node is CompoundStack compoundStack)
                {
                    total += GetTotalCount(func) * compoundStack.Count;
                }
            }

            return total;
        }

        /// <summary>
        /// Static method for creating new Compounds.
        /// </summary>
        /// <param name="chemicalCompound"> Formula to parse </param>
        /// <param name="chemicalName"> Chemical name of the Compound </param>
        /// <param name="commonName"> Common name of the Compound </param>
        /// <param name="parser"> Parser uses to parse the Compound. By default it will use CondensedChemicalCompoundParser as a parser. </param>
        /// <returns></returns>
        public static ChemicalCompound New(string chemicalCompound, string chemicalName, IChemicalCompoundParser parser = null)
        {
            parser ??= new CondensedChemicalCompoundParser();

            var compound = parser.Read(chemicalCompound);
            compound.Formula = chemicalCompound;
            compound.ChemicalName = chemicalName;

            return compound;
        }
    }
}
