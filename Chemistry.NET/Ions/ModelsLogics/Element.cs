/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Ions;

namespace Chemistry.NET.Elements.Models
{
    public partial class Element : IIonizable
    {
        public bool IsAnion => Structure.ElectronsCount > Structure.ProtonsCount;
        public bool IsCation => Structure.ElectronsCount < Structure.ProtonsCount;
        public bool IsMonatomic => true;
        public bool IsPolyatomic => false;
    }
}
