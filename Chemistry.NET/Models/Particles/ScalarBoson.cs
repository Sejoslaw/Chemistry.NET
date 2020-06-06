/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models.Particles
{
    public partial class ScalarBoson : Boson
    {
        public ScalarBoson(string name, string symbol, double mass, double charge, double spin)
         : base(name, symbol, mass, charge, spin)
        {
        }
    }
}
