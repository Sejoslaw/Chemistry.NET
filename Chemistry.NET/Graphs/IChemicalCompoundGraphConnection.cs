/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;

namespace Chemistry.NET.Graphs
{
    /// <summary>
    /// Describes a single connection between 2 nodes in Graph.
    /// </summary>
    public interface IChemicalCompoundGraphConnection
    {
        /// <summary>
        /// Unique Identifier of the current connection.
        /// </summary>
        /// <value></value>
        Guid ConnectionId { get; }
        /// <summary>
        /// Graph to which the current connection belongs.
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraph Graph { get; }
        /// <summary>
        /// Parent of the connection.
        /// Also can be called "Left Node".
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraphNode Parent { get; }
        /// <summary>
        /// Child of the connection.
        /// Also can be called "Right Node".
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraphNode Child { get; }
        /// <summary>
        /// Represents the strength of the connection.
        /// Number of connections between the nodes.
        /// </summary>
        /// <value></value>
        int Count { get; }
    }
}
