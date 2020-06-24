/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
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
        public virtual IEnumerable<ElementStack> GetAtoms()
        {
            return StructureTree.GetAtoms();
        }

        public virtual int GetTotalElectronsCount()
        {
            return StructureTree.GetTotalElectronsCount();
        }

        public virtual int GetTotalProtonsCount()
        {
            return StructureTree.GetTotalProtonsCount();
        }

        public virtual int GetTotalNeutronsCount()
        {
            return StructureTree.GetTotalNeutronsCount();
        }

        public virtual bool AreAtomsCountEqual(ChemicalCompound compound)
        {
            return StructureTree.AreAtomsCountEqual(compound.StructureTree);
        }
        
        public virtual bool ContainsBond(params Element[] elements)
        {
            return StructureTree.ContainsBond(elements);
        }

        public virtual bool ContainsBond(params ElementStack[] stacks)
        {
            return StructureTree.ContainsBond(stacks);
        }

        /// <summary>
        /// Static method for creating new Compounds.
        /// </summary>
        /// <param name="chemicalCompound"> Formula to parse </param>
        /// <param name="chemicalName"> Chemical name of the Compound </param>
        /// <param name="commonName"> Common name of the Compound </param>
        /// <param name="parser"> Parser uses to parse the Compound. By default it will use CondensedChemicalCompoundParser as a parser. </param>
        /// <returns></returns>
        public static ChemicalCompound New(string chemicalCompound, string chemicalName = "", IChemicalCompoundParser parser = null)
        {
            parser ??= new CondensedChemicalCompoundParser();

            var compound = parser.Read(chemicalCompound);
            compound.Formula = chemicalCompound;
            compound.ChemicalName = chemicalName;

            return compound;
        }
    }
}
