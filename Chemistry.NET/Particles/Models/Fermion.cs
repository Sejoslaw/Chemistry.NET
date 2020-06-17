/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Particles.Models
{
    public partial class Fermion : Particle
    {
        public int Generation { get; }

        public Fermion(string name, string symbol, double mass, double charge, double spin, int generation)
         : base(name, symbol, mass, charge, spin)
        {
            Generation = generation;
        }
    }
}
