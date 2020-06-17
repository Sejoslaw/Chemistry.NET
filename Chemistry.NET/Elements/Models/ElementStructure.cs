/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Represents a structure of an element
    /// </summary>
    public partial class ElementStructure
    {
        public string ElementName { get; }
        public int ProtonsCount { get; }
        public int ElectronsCount { get; }
        public int NeutronsCount { get; }
        public int ValenceElectrons { get; }

        public ElementStructure(string elementName, int protonsCount, int electronsCount, int neutronsCount, int valenceElectrons)
        {
            ElementName = elementName;
            ProtonsCount = protonsCount;
            ElectronsCount = electronsCount;
            NeutronsCount = neutronsCount;
            ValenceElectrons = valenceElectrons;
        }
    }
}
