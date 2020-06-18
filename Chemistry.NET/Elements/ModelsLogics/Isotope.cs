/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Common;

namespace Chemistry.NET.Elements.Models
{
    public partial class Isotope
    {
        /// <summary>
        /// Returns the Nuclide Number from the Atomic Number.
        /// </summary>
        /// <returns></returns>
        public virtual int GetNuclideNumber()
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
        public virtual int GetNeutronExcess()
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
        public virtual IEnumerable<Isotope> GetIsobars()
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
        public virtual IEnumerable<Isotope> GetIsotones()
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
        public virtual IEnumerable<Isotope> GetIsodiaphers()
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
        public virtual IEnumerable<Isotope> GetMirrorNuclei()
        {
            return Container
                .Isotopes
                .Where(isotope => isotope.NeutronCount.Equals(ProtonCount) && 
                                  isotope.ProtonCount.Equals(NeutronCount))
                .ToList();
        }
        
        /// <summary>
        /// Returns the known Isomers for the current Isotope.
        /// Z1 = Z2 and Mass1 = Mass2
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<Isotope> GetIsomers()
        {
            return Container
                .Isotopes
                .Where(isotope => isotope.ProtonCount.Equals(ProtonCount) && 
                                  isotope.IsotopicMass.Equals(IsotopicMass))
                .ToList();
        }
    }
}