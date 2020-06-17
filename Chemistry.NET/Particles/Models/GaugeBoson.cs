/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Particles.Models
{
    /// <summary>
    /// Also known as Vector Boson
    /// </summary>
    public partial class GaugeBoson : Boson
    {
        public GaugeBoson(string name, string symbol, double mass, double charge, double spin)
         : base(name, symbol, mass, charge, spin)
        {
        }
    }
}
