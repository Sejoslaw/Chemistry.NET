/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Graphs
{
    /// <summary>
    /// Represents a single node in the Graph.
    /// </summary>
    public interface IChemicalCompoundGraphNode
    {
        /// <summary>
        /// Graph to which the current node belongs.
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraph Graph { get; }
        /// <summary>
        /// Unique Identifier of the Node.
        /// </summary>
        /// <value></value>
        Guid NodeId { get; }
        /// <summary>
        /// Element described by the current node.
        /// </summary>
        /// <value></value>
        Element Element { get; }
        /// <summary>
        /// Represents the number of all bonds between this node and others.
        /// If there is a double bond connection it is counted as 2, etc.
        /// </summary>
        /// <value></value>
        int TotalBondsCount { get; }
        /// <summary>
        /// Number of available valence electrons by which the new bonds can be formed.
        /// </summary>
        /// <value></value>
        int AvailableBondsCount { get; }
    }
}
