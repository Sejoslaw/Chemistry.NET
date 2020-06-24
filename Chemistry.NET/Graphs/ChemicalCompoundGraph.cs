/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Models;

namespace Chemistry.NET.Graphs
{
    public class ChemicalCompoundGraph : IChemicalCompoundGraph
    {
        public ChemicalCompound Compound { get; }
        
        public ChemicalCompoundGraph(ChemicalCompound chemicalCompound)
        {
            Compound = chemicalCompound;
        }

        /// <summary>
        /// Generates graph from specified Chemical Compound.
        /// </summary>
        public void Generate()
        {
        }
    }
}
