/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Particles.Models
{
    public partial class Boson : Particle
    {
        public Boson(string name, string symbol, double mass, double charge, double spin)
         : base(name, symbol, mass, charge, spin)
        {
        }
    }
}
