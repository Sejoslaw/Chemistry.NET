/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Models;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class MoleculeTests
    {
        [Theory]
        [InlineData("H2", true, false, true)]
        [InlineData("H2O", false, true, false)]
        [InlineData("CHO", false, true, false)]
        [InlineData("CH(CH2)4", false, true, false)]
        [InlineData("CH", false, true, true)]
        [InlineData("CH(CH2Li3)4", false, true, false)]
        public void Check_molecule_properties(string compoundSymbol, bool isHomonuclear, bool isHeteronuclear, bool isDiatomic)
        {
            var compound = ChemicalCompound.New(compoundSymbol, "");
            
            Assert.Equal(compound.IsHomonuclear, isHomonuclear);
            Assert.Equal(compound.IsHeteronuclear, isHeteronuclear);
            Assert.Equal(compound.IsDiatomic, isDiatomic);
        }
    }
}