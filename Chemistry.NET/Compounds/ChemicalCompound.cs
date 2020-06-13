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
        /// Holds the information of how the Compound is build.
        /// </summary>
        internal CompoundStack Stack { get; } = new CompoundStack();
    }
}
