/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Particles.Models
{
    public partial class Hadron : Particle
    {
        public string QuarkContent { get; }
        public double Isospin { get; }
        public double TotalAngularMomentum { get; }
        public double Strangeness { get; }
        public double Bottomness { get; }
        public string Lifetime { get; }
        public double Charm { get; }

        public Hadron(
            string name, string symbol, string quarkContent,
            double isospin, double totalAngularMomentum, double strangeness,
            double mass, double charge, double spin,
            double bottomness, string lifetime, double charm)
         : base(name, symbol, mass, charge, spin)
        {
            QuarkContent = quarkContent;
            Isospin = isospin;
            TotalAngularMomentum = totalAngularMomentum;
            Strangeness = strangeness;
            Bottomness = bottomness;
            Lifetime = lifetime;
            Charm = charm;
        }
    }
}
