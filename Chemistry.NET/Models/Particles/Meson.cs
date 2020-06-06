/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class Meson : Hadron
    {
        public Meson(
            string name, string symbol, string antiparticleSymbol,
            string quarkContent, double mass, double isospin,
            double totalAngularMomentum, double strangeness,
            double charm, double bottomness, string lifetime,
            double charge, double spin)
             : base(
                 name, symbol, quarkContent,
                 isospin, totalAngularMomentum, strangeness,
                 mass, charge, spin,
                 bottomness, lifetime, charm)
        {
        }
    }
}
