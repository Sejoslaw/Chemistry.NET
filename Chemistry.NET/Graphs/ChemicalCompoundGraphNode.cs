/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Linq;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Graphs
{
    public class ChemicalCompoundGraphNode : IChemicalCompoundGraphNode
    {
        public Guid NodeId { get; } = Guid.NewGuid();
        public IChemicalCompoundGraph Graph { get; }
        public Element Element { get; }
        public int TotalBondsCount => Element.Structure.ValenceElectrons;
        public int AvailableBondsCount => TotalBondsCount - Graph.Connections.Where(c => NodeId == c.Child.NodeId || NodeId == c.Parent.NodeId).Count();

        public ChemicalCompoundGraphNode(IChemicalCompoundGraph graph, Element element)
        {
            Graph = graph;
            Element = element;
        }
    }
}
