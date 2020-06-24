/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Graphs;

namespace Chemistry.NET.Compounds.Models
{
    public partial class ChemicalCompound
    {
        /// <summary>
        /// Generates Graph from the current Chemical Compound.
        /// </summary>
        /// <returns></returns>
        public virtual IChemicalCompoundGraph GenerateGraph()
        {
            var graph = new ChemicalCompoundGraph(this);
            graph.Generate();
            return graph;
        }
    }
}
