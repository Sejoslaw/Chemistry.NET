/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    /// <summary>
    /// Describes any elementary particle
    /// </summary>
    public partial class Particle
    {
        public string Name { get; }
        public string Symbol { get; }
        public double Mass { get; }
        public double Charge { get; }
        public double Spin { get; }

        public Particle(string name, string symbol, double mass, double charge, double spin)
        {
            Name = name;
            Symbol = symbol;
            Mass = mass;
            Charge = charge;
            Spin = spin;
        }
    }
}
