/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Ions;

namespace Chemistry.NET.Compounds.Models
{
    public partial class ChemicalCompound : IIonizable
    {
        public bool IsAnion => GetTotalElectronsCount() > GetTotalProtonsCount();
        public bool IsCation => GetTotalElectronsCount() < GetTotalProtonsCount();
        public bool IsMonatomic => StructureTree.Count == 1 && StructureTree.Nodes[0] is ElementStack elementStack && elementStack.Count == 1;
        public bool IsPolyatomic => !IsMonatomic;
    }
}
