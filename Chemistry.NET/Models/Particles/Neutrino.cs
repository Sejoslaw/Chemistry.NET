/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class Neutrino : Lepton
    {
        public Neutrino(
            string name, string symbol, double mass,
            double charge, double spin, int generation,
            double electronicCount, double muonicCount, double tauonicCount)
             : base(
                 name, symbol, mass,
                 charge, spin, generation,
                 electronicCount, muonicCount, tauonicCount)
        {
        }
    }
}
