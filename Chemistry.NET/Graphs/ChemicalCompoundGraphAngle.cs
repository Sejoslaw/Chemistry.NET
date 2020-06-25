/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Graphs
{
    public class ChemicalCompoundGraphAngle : IChemicalCompoundGraphAngle
    {
        public IChemicalCompoundGraph Graph { get; }
        public IChemicalCompoundGraphConnection Connection1 { get; }
        public IChemicalCompoundGraphConnection Connection2 { get; }
        public double Angle { get; }

        public ChemicalCompoundGraphAngle(IChemicalCompoundGraph graph, IChemicalCompoundGraphConnection connection1, IChemicalCompoundGraphConnection connection2, double angle)
        {
            Graph = graph;
            Connection1 = connection1;
            Connection2 = connection2;
            Angle = angle;
        }
    }
}
