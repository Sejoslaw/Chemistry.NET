/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Definition of a standard element.
    /// </summary>
    public partial class Element
    {
        public int AtomicNumber { get; }
        public string Symbol { get; }
        public string Name { get; }
        public double AtomicMass { get; }
        public string ColorHex { get; }
        public ElectronConfiguration ElectronConfiguration { get; }
        public string Electronegativity { get; }
        public string AtomicRadius { get; }
        public string IonizationEnergy { get; }
        public string ElectronAffinity { get; }
        public string OxidationStates { get; }
        public PhysicalState StandardState { get; }
        public string MeltingPoint { get; }
        public string BoilingPoint { get; }
        public string Density { get; }
        public ElementType GroupBlock { get; }
        public int YearDiscovered { get; }
        public ElementStructure Structure { get; }

        public Element(
            int atomicNumber, string symbol, string name,
            double atomicMass, string colorHex, ElectronConfiguration electronConfiguration,
            string electronegativity, string atomicRadius, string ionizationEnergy,
            string electronAffinity, string oxidationStates, PhysicalState standardState,
            string meltingPoint, string boilingPoint, string density,
            ElementType groupBlock, int yearDiscovered, ElementStructure structure)
        {
            AtomicNumber = atomicNumber;
            Symbol = symbol;
            Name = name;
            AtomicMass = atomicMass;
            ColorHex = colorHex;
            ElectronConfiguration = electronConfiguration;
            Electronegativity = electronegativity;
            AtomicRadius = atomicRadius;
            IonizationEnergy = ionizationEnergy;
            ElectronAffinity = electronAffinity;
            OxidationStates = oxidationStates;
            StandardState = standardState;
            MeltingPoint = meltingPoint;
            BoilingPoint = boilingPoint;
            Density = density;
            GroupBlock = groupBlock;
            YearDiscovered = yearDiscovered;
            Structure = structure;
        }
    }
}
