/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Collections;

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
    }
}
