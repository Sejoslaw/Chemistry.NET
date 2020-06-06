/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using System.Linq;

namespace Chemistry.NET.Models.Particles
{
    public partial class Baryon : Hadron
    {
        private ICollection<Quark> _quarks;
        public IEnumerable<Quark> Quarks
        {
            get
            {
                if (_quarks != null)
                {
                    return _quarks;
                }

                _quarks = new List<Quark>();

                foreach (var particle in QuarkContent)
                {
                    var quark = Container.Particles.Where(p => p is Quark && p.Symbol.Equals(particle)).FirstOrDefault();
                    _quarks.Add(quark as Quark);
                }

                _quarks = (_quarks as List<Quark>).AsReadOnly();

                return _quarks;
            }
        }

        public Baryon(
            string name, string symbol, string quarkContent,
            double mass, double isospin, double totalAngularMomentum,
            double charge, double strangeness, double charm,
            double bottomness, string lifetime, double spin)
            : base(
                name, symbol, quarkContent,
                isospin, totalAngularMomentum, strangeness,
                mass, charge, spin,
                bottomness, lifetime, charm)
        {
        }
    }
}
