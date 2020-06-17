/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Compounds.Parsers.ChemicalCompounds;

namespace Chemistry.NET.Compounds.Models
{
    /// <summary>
    /// Represents the core Chemical Compound.
    /// </summary>
    public partial class ChemicalCompound
    {
        /// <summary>
        /// Holds the information of the Compound Structure Tree.
        /// </summary>
        internal CompoundStack StructureTree { get; } = new CompoundStack();
        
        /// <summary>
        /// Chemical formula from which the current Compound was parsed.
        /// </summary>
        public string Formula { get; internal set; }
        /// <summary>
        /// Chemical name of this Compound.
        /// </summary>
        public string ChemicalName { get; internal set; }

        /// <summary>
        /// For internal usage.
        /// </summary>
        internal ChemicalCompound(string formula)
        {
            Formula = formula;
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
