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
        [InlineData("Li1234")]
        [InlineData("O12")]
        [InlineData("O1234")]
        [InlineData("H2O")]
        [InlineData("O2H2")]
        [InlineData("O1234H1234")]
        [InlineData("OH")]
        [InlineData("CH(OH)3")]
        [InlineData("CH2(OH)4")]
        [InlineData("Li2O4((H7C123)12OH)CO(H)3")]
        public void Should_parse_ChemicalCompound_using_CondensedChemicalCompoundParser(string input)
        {
            var parser = new CondensedChemicalCompoundParser();
            var compound = parser.Read(input);
            var str = parser.Write(compound);
            
            Assert.Equal(input, str);
        }
        
        [Theory]
        [InlineData("H-H")]
        [InlineData("(H)2-O")]
        [InlineData("(H)4-C")]
        [InlineData("(H)2-C=C-(H)2")]
        [InlineData("(H)2-C-(OH)2")]
        [InlineData("(Li)2-O-(C=Pb-C-(H)2)-(O=C)")]
        [InlineData("Li|10|H")]
        [InlineData("(Li)2-O-(C=Pb-C-(H)2)-(O|8|C)")]
        [InlineData("(Li)2-O-(C=Pb-C|10|(H)2)-(O=C)")]
        public void Should_parse_ChemicalCompound_using_LewisChemicalCompoundParser(string input)
        {
            var parser = new LewisChemicalCompoundParser();
            var compound = parser.Read(input);
            var str = parser.Write(compound);
            
            Assert.Equal(input, str);
        }
    }
}
