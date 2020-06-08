/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class AntiQuark : Quark
    {
        public AntiQuark(
            string name, string symbol, double mass,
            double charge, double spin, int generation,
            double totalAngularMomentum, double baryonNumber, double isospin,
            double charm, double strangeness, double topness,
            double bottomness)
             : base(
                 name, symbol, mass,
                 charge, spin, generation,
                 totalAngularMomentum, baryonNumber, isospin,
                 charm, strangeness, topness,
                 bottomness)
        {
        }
    }
}
