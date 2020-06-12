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
        public void Check_if_Isobars_of_sample_Isotopes_exists()
        {
            PrepareTestEnv(sampleIsotope =>
            {
                var isobars = sampleIsotope.GetIsobars();
                return isobars.Any();
            });
        }

        [Fact]
        public void Check_if_Isotones_of_sample_Isotopes_exists()
        {
            PrepareTestEnv(sampleIsotope =>
            {
                var isotones = sampleIsotope.GetIsotones();
                return isotones.Any();
            });
        }
        
        [Fact]
        public void Check_if_Isodiaphers_of_sample_Isotopes_exists()
        {
            PrepareTestEnv(sampleIsotope =>
            {
                var isodiaphers = sampleIsotope.GetIsodiaphers();
                return isodiaphers.Any();
            });
        }
        
        [Fact]
        public void Check_if_Mirror_Nuclei_of_sample_Isotopes_exists()
        {
            PrepareTestEnv(sampleIsotope =>
            {
                var mirrorNuclei = sampleIsotope.GetMirrorNuclei();
                return mirrorNuclei.Any();
            });
        }
        
        [Fact]
        public void Check_if_Isomers_of_sample_Isotopes_exists()
        {
            PrepareTestEnv(sampleIsotope =>
            {
                var isomers = sampleIsotope.GetIsomers();
                return isomers.Any();
            });
        }

        private static void PrepareTestEnv(Func<Isotope, bool> action)
        {
            var rand = new Random();
            
            // Sample random number of tests
            for (var i = 0; i < 100; ++i)
            {
                var randomValue = rand.Next(Container.Isotopes.Count() - 1);
                var sampleIsotope = Container.Isotopes.ElementAt(randomValue);
                var result = action(sampleIsotope);
                
                if (!result)
                {
                    // For debug purposes
                    continue;
                }
                
                Assert.True(result);
            }
        }
    }
}
