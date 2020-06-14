/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Collections;

namespace Chemistry.NET.Compounds
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
    }
}
