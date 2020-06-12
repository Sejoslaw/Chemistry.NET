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
        
        /// <summary>
        /// Returns the Nuclide Number from the Atomic Number.
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

            return -1;
        }
        
        /// <summary>
        /// Returns the excess amount of Neutrons.
        /// </summary>
        /// <returns></returns>
        public int GetNeutronExcess()
        {
            if (!double.TryParse(NeutronCount, out var neutrons))
            {
                if (NeutronCount.Equals(""))
                {
                    neutrons = BaseElement.Structure.NeutronsCount;
                }
                else
                {
                    return -1;
                }
            }
            
            if (!double.TryParse(ProtonCount, out var protons))
            {
                if (ProtonCount.Equals(""))
                {
                    protons = BaseElement.Structure.ProtonsCount;
                }
                else
                {
                    return -1;
                }
            }

            return (int)neutrons - (int)protons;
        }
        
        /// <summary>
        /// Returns the known Isobars from the current Isotope.
        /// Different Isotopes with the same Nuclide Number.
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

        /// <summary>
        /// Returns the known Isotopes from the current Isotope.
        /// Different Isotopes with the same Neutron Number but different Proton Number.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Isotope> GetIsotones()
        {
            return Container
                .Isotopes
                .Where(isotope => isotope.NeutronCount.Equals(NeutronCount) &&
                                  isotope.ProtonCount.Equals(ProtonCount))
                .ToList();
        }
        
        /// <summary>
        /// Returns the known Isodiaphers from the current Isotope.
        /// Equal Neutron excess.
        /// N1 - Z1 = N2 - Z2
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Isotope> GetIsodiaphers()
        {
            var excessNeutrons = GetNeutronExcess();
            return Container
                .Isotopes
                .Where(isotope => excessNeutrons == isotope.GetNeutronExcess())
                .ToList();
        }
        
        /// <summary>
        /// Returns the known Mirror Nuclei's.
        /// Z1 = N2 and Z2 = N1
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Isotope> GetMirrorNuclei()
        {
            return Container
                .Isotopes
                .Where(isotope => isotope.NeutronCount.Equals(ProtonCount) && 
                                  isotope.ProtonCount.Equals(NeutronCount))
                .ToList();
        }

        public IEnumerable<Isotope> GetIsomers()
        {
            return Container
                .Isotopes
                .Where(isotope => isotope.ProtonCount.Equals(ProtonCount) && 
                                  isotope.IsotopicMass.Equals(IsotopicMass))
                .ToList();
        }
    }
}
