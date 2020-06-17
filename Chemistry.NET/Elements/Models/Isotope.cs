/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Definition of a known, non-hypothetical Isotope.
    /// </summary>
    public partial class Isotope
    {
        public Element BaseElement { get; }
        public string Nuclide { get; }
        /// <summary>
        /// Same as Atomic Number.
        /// </summary>
        public string ProtonCount { get; }
        public string NeutronCount { get; }
        /// <summary>
        /// Mass in Daltons.
        /// </summary>
        public string IsotopicMass { get; }
        public string Halftime { get; }
        public string Decay { get; }
        public string DaughterIsotope { get; }
        public string Spin { get; }
        public string Parity { get; }

        public Isotope(
            Element baseElement, string nuclide, string protonCount, 
            string neutronCount, string isotopicMass, string halftime,
            string decay, string daughterIsotope, string spin,
            string parity)
        {
            BaseElement = baseElement;
            Nuclide = nuclide;
            ProtonCount = protonCount;
            NeutronCount = neutronCount;
            IsotopicMass = isotopicMass;
            Halftime = halftime;
            Decay = decay;
            DaughterIsotope = daughterIsotope;
            Spin = spin;
            Parity = parity;
        }
    }
}
