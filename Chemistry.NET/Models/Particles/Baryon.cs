/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class Baryon : Hadron
    {
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
