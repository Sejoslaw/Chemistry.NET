/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Common;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class ContainerTests
    {
        [Fact]
        public void Are_Container_properties_correctly_returned()
        {
            Assert.NotEmpty(Container.Particles);
            Assert.NotEmpty(Container.ElectronShells);
            Assert.NotEmpty(Container.Elements);
            Assert.NotEmpty(Container.ElementTypes);
            Assert.NotEmpty(Container.PeriodicTableElements);
            Assert.NotEmpty(Container.PeriodicTableGroups);
            Assert.NotEmpty(Container.PhysicalStates);
            Assert.NotEmpty(Container.ElementStructures);
            Assert.NotEmpty(Container.Isotopes);
            Assert.NotEmpty(Container.CommonCompounds);
            Assert.NotEmpty(Container.Ions);
            Assert.NotEmpty(Container.MonoisotopicElements);
            Assert.NotEmpty(Container.MononuclidicElements);
            Assert.NotEmpty(Container.AlphaNuclides);
            Assert.NotEmpty(Container.PrimordialNuclides);
        }
    }
}
