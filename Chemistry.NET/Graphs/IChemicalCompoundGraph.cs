/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Models;

namespace Chemistry.NET.Graphs
{
    /// <summary>
    /// Describes the Graph representation of a single Chemical Compound.
    /// </summary>
    public interface IChemicalCompoundGraph
    {
        /// <summary>
        /// Chemical Compound described by the current graph
        /// </summary>
        /// <value></value>
        ChemicalCompound Compound { get; }

        /// <summary>
        /// Initialize the generation of the graph.
        /// </summary>
        void Generate();
    }
}
