/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class Quark : Fermion
    {
        public double TotalAngularMomentum { get; }
        public double BaryonNumber { get; }
        public double Isospin { get; }
        public double Charm { get; }
        public double Strangeness { get; }
        public double Topness { get; }
        public double Bottomness { get; }

        public Quark(
            string name, string symbol, double mass, 
            double charge, double spin, int generation,
            double totalAngularMomentum, double baryonNumber, double isospin,
            double charm, double strangeness, double topness, 
            double bottomness)
         : base(name, symbol, mass, charge, spin, generation)
        {
            TotalAngularMomentum = totalAngularMomentum;
            BaryonNumber = baryonNumber;
            Isospin = isospin;
            Charm = charm;
            Strangeness = strangeness;
            Topness = topness;
            Bottomness = bottomness;
        }
    }
}
