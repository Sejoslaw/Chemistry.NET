/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Linq;
using Chemistry.NET.Common;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class ElementTests
    {
        [Theory]
        [InlineData("H", 2)]
        [InlineData("Co", 2)]
        [InlineData("Li", 1)]
        [InlineData("At", 5)]
        public void Should_check_number_of_oxidation_states(string elementSymbol, int oxidationStates)
        {
            var element = Container.Elements.FirstOrDefault(e => e.Symbol.Equals(elementSymbol));
            var ions = element.GetOxidationStates();
            Assert.Equal(ions.Count(), oxidationStates);
        }
    }
}
