/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;

namespace Chemistry.NET.Models
{
    public partial class Isotope
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
        
        /// <summary>
        /// Returns the Nuclide Number from the Atomic Number
        /// </summary>
        /// <returns></returns>
        public int GetNuclideNumber()
        {
            for (var i = 0; i < Nuclide.Length; ++i)
            {
                if (char.IsNumber(Nuclide[i]))
                {
                    continue;
                }
                
                var numberString = Nuclide.Substring(0, i);
                var nuclideValue = int.Parse(numberString);
                return nuclideValue;
            }
            
            throw new FormatException($"Unable to parse Nuclide Number of Isotope: { Nuclide }");
        }
        
        /// <summary>
        /// Returns the known Isobars from the current Isotope
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Isotope> GetIsobars()
        {
            var nuclideNumber = GetNuclideNumber();
            return Container
                .Isotopes
                .Where(isotope => isotope.GetNuclideNumber() == nuclideNumber && !isotope.Nuclide.Equals(Nuclide))
                .ToList();
        }
    }
}
