/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Parsers.Compounds;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class CondensedChemicalCompoundParserTests
    {
        [Theory]
        [InlineData("O")]
        [InlineData("O2")]
        [InlineData("O12")]
        [InlineData("O1234")]
        [InlineData("H2O")]
        [InlineData("O2H2")]
        [InlineData("OH")]
        [InlineData("CH(OH)3")]
        [InlineData("CH2(OH)4")]
        [InlineData("Li2O4((H7C123)12OH)CO(H)3")]
        public void Should_parse_ChemicalCompound(string input)
        {
            var parser = new CondensedChemicalCompoundParser();
            var compound = parser.Read(input);
            var str = parser.Write(compound);
            
            Assert.Equal(input, str);
        }
    }
}
