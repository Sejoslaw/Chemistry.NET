/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Compounds.Models
{
    public partial class ChemicalCompound
    {
        public bool HasHydroxyGroup => ContainsBond(CommonElements.Oxygen, CommonElements.Hydrogen);
        public bool HasAminoGroup => ContainsBond(CommonElements.Nitrogen.ToStack(), CommonElements.Hydrogen.ToStack(2));
    }
}
