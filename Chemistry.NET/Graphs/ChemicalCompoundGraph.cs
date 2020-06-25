/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using Chemistry.NET.Compounds.Models;

namespace Chemistry.NET.Graphs
{
    public class ChemicalCompoundGraph : IChemicalCompoundGraph
    {
        public ChemicalCompound Compound { get; }
        public IEnumerable<IChemicalCompoundGraphConnection> Connections { get; } = new List<IChemicalCompoundGraphConnection>();
        public IEnumerable<IChemicalCompoundGraphAngle> Angles { get; } = new List<IChemicalCompoundGraphAngle>();
        
        public ChemicalCompoundGraph(ChemicalCompound chemicalCompound)
        {
            Compound = chemicalCompound;
        }

        /// <summary>
        /// Generates graph from current Chemical Compound.
        /// </summary>
        public void Generate()
        {
        }
    }
}
