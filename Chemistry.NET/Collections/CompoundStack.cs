/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;

namespace Chemistry.NET.Collections
{
    /// <summary>
    /// Represents an information of how the Chemical Compound is build.
    /// </summary>
    public partial class CompoundStack : IChemicalStack
    {
        internal IList<IChemicalStack> Nodes { get; } = new List<IChemicalStack>();
        public int Count { get; private set; }
        
        public void IncreaseStackSize(int count = 1)
        {
            Count += count;
        }
    }
}
