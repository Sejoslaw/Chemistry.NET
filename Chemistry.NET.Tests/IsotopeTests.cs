/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Linq;
using Chemistry.NET.Models;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class IsotopeTests
    {
        [Fact]
        public void Check_if_Isobars_of_sample_Isotope_exists()
        {
            var rand = new Random();
            
            // Sample random number of tests
            for (var i = 0; i < 100; ++i)
            {
                var randomValue = rand.Next(Container.Isotopes.Count() - 1);
                var sampleIsotope = Container.Isotopes.ElementAt(randomValue);
                var isobars = sampleIsotope.GetIsobars();
                Assert.NotEmpty(isobars);
            }
        }
    }
}
