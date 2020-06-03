/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Definition of a standard element.
    /// </summary>
    public partial class Element
    {
        private static List<Element> _all;
        public static IEnumerable<Element> All
        {
            get
            {
                if (_all != null)
                {
                    return _all;
                }

                _all = new List<Element>();

                foreach (var property in typeof(Elements).GetFields())
                {
                    _all.Add(property.GetValue(null) as Element);
                }

                return _all.AsReadOnly();
            }
        }

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

        public Element(
            int atomicNumber, string symbol, string name,
            double atomicMass, string colorHex, ElectronConfiguration electronConfiguration,
            string electronegativity, string atomicRadius, string ionizationEnergy,
            string electronAffinity, string oxidationStates, PhysicalState standardState,
            string meltingPoint, string boilingPoint, string density,
            ElementType groupBlock, int yearDiscovered)
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
        }
    }
}
