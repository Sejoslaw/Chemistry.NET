/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Graphs
{
    public class ChemicalCompoundGraphConnection : IChemicalCompoundGraphConnection
    {
        public IChemicalCompoundGraph Graph { get; }
        public IChemicalCompoundGraphNode Parent { get; }
        public IChemicalCompoundGraphNode Child { get; }
        public int Count { get; }

        public ChemicalCompoundGraphConnection(IChemicalCompoundGraph graph, IChemicalCompoundGraphNode parent, IChemicalCompoundGraphNode child, int count = 1)
        {
            Graph = graph;
            Parent = parent;
            Child = child;
            Count = count;
        }
    }
}
