/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Particles.Models
{
    public partial class Nucleon : Baryon
    {
        public Nucleon(
            string name, string symbol, string quarkContent, 
            double mass, double isospin, double totalAngularMomentum, 
            double charge, double strangeness, double charm, 
            double bottomness, string lifetime, double spin)
             : base(name, symbol, quarkContent, 
                    mass, isospin, totalAngularMomentum, 
                    charge, strangeness, charm, 
                    bottomness, lifetime, spin)
        {
        }
    }
}
