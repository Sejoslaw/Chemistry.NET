/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Linq;
using Chemistry.NET.Compounds.Models;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class ChemicalCompoundGraphTests
    {
        [Theory]
        [InlineData("H2O", 2)]
        [InlineData("CH4", 4)]
        [InlineData("CH2C(OH)2", 7)]
        public void Should_calculate_number_of_connections_in_Graph(string compoundSymbol, int connectionsCount)
        {
            var compound = ChemicalCompound.New(compoundSymbol);
            var graph = compound.GenerateGraph();

            Assert.Equal(graph.Connections.Count(), connectionsCount);
        }
    }
}
