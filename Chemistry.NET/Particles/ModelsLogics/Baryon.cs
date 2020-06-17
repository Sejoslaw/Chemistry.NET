/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Common;

namespace Chemistry.NET.Particles.Models
{
    public partial class Baryon
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

                foreach (var quark in QuarkContent.Select(particle => Container.Particles.FirstOrDefault(p => p is Quark && p.Symbol.Equals(particle.ToString()))))
                {
                    _quarks.Add(quark as Quark);
                }

                _quarks = (_quarks as List<Quark>)?.AsReadOnly();

                return _quarks;
            }
        }
    }
}
