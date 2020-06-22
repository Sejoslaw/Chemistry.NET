/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Compounds.Models
{
    public partial class ChemicalCompound : IOrganicCompound
    {
        public bool IsOrganic => ContainsBond(CommonElements.Carbon, CommonElements.Hydrogen);
    }
}
