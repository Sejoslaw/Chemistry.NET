/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class Lepton : Fermion
    {
        public double ElectronicCount { get; }
        public double MuonicCount { get; }
        public double TauonicCount { get; }

        public Lepton(
            string name, string symbol, double mass,
            double charge, double spin, int generation,
            double electronicCount, double muonicCount, double tauonicCount)
         : base(name, symbol, mass, charge, spin, generation)
        {
            ElectronicCount = electronicCount;
            MuonicCount = muonicCount;
            TauonicCount = tauonicCount;
        }
    }
}
