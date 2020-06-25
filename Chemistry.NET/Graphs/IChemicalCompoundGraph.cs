/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Models;
using System.Collections.Generic;

namespace Chemistry.NET.Graphs
{
    /// <summary>
    /// Describes the Graph representation of a single Chemical Compound.
    /// </summary>
    public interface IChemicalCompoundGraph
    {
        /// <summary>
        /// Chemical Compound described by the current Graph.
        /// </summary>
        /// <value></value>
        ChemicalCompound Compound { get; }
        /// <summary>
        /// Collection of Connections inside the Graph.
        /// </summary>
        /// <value></value>
        IEnumerable<IChemicalCompoundGraphConnection> Connections { get; }

        /// <summary>
        /// Initialize the generation of the Graph.
        /// </summary>
        void Generate();
    }
}
