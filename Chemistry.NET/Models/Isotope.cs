/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    public class Isotope
    {
        public Element BaseElement { get; }
        public string Nuclide { get; }
        /// <summary>
        /// Same as Proton count.
        /// </summary>
        public string AtomicNumber { get; }
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
            Element baseElement, string nuclide, string atomicNumber, 
            string neutronCount, string isotopicMass, string halftime,
            string decay, string daughterIsotope, string spin,
            string parity)
        {
            BaseElement = baseElement;
            Nuclide = nuclide;
            AtomicNumber = atomicNumber;
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
