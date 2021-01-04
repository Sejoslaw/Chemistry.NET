/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Common;
using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Compounds.Models;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class ChemicalStackTests
    {
        [Fact]
        public void Should_calculate_electrons_neutrons_protons_for_ElementStack()
        {
            foreach (var element in Container.Elements)
            {
                var randomElementNumberOnStack = new Random().Next();
                var stack = new ElementStack(element, randomElementNumberOnStack);

                Assert.Equal(stack.GetTotalElectronsCount(), element.Structure.ElectronsCount * randomElementNumberOnStack);
                Assert.Equal(stack.GetTotalNeutronsCount(), element.Structure.NeutronsCount * randomElementNumberOnStack);
                Assert.Equal(stack.GetTotalProtonsCount(), element.Structure.ProtonsCount * randomElementNumberOnStack);

                var count = stack.GetAtoms().Count();
                Assert.Equal(1, count);
            }
        }

        [Theory]
        [InlineData("H2O", 10, 8, 10, 2)]
        [InlineData("H2O2", 18, 16, 18, 2)]
        [InlineData("H(CH2)4", 33, 24, 33, 2)]
        public void Should_calculate_electrons_neutrons_protons_for_CompoundStack(string compoundSymbol, int electrons, int neutrons, int protons, int atoms)
        {
            var compound = ChemicalCompound.New(compoundSymbol);

            Assert.Equal(compound.GetTotalElectronsCount(), electrons);
            Assert.Equal(compound.GetTotalNeutronsCount(), neutrons);
            Assert.Equal(compound.GetTotalProtonsCount(), protons);
            Assert.Equal(compound.GetAtoms().Count(), atoms);
        }

        [Theory]
        [InlineData("H2O", "OH2")]
        [InlineData("CH(CH4)2", "(CH4)2CH")]
        [InlineData("((CH3)2)4O2", "C6H20O2(CH2)2")]
        public void Should_contain_the_same_atoms(string symbol1, string symbol2)
        {
            var compound1 = ChemicalCompound.New(symbol1);
            var compound2 = ChemicalCompound.New(symbol2);

            Assert.True(compound1.AreIsomers(compound2));
        }
        
        [Theory]
        [InlineData("H2O", false)]
        [InlineData("C2(OH)2", false)]
        [InlineData("CLi((CH3)O)2Li12", true)]
        public void Should_be_an_organic_compound(string compoundSymbol, bool isOrganic)
        {
            var compound = ChemicalCompound.New(compoundSymbol);
            
            Assert.Equal(compound.IsOrganic, isOrganic);
        }

        [Theory]
        [InlineData("H2O", true)]
        [InlineData("C2(OH)2", true)]
        [InlineData("LiOC", false)]
        public void Should_contain_hydroxy_group(string compoundSymbol, bool hasHydroxyGroup)
        {
            var compound = ChemicalCompound.New(compoundSymbol);

            Assert.Equal(compound.HasHydroxyGroup, hasHydroxyGroup);
        }

        [Theory]
        [InlineData("NH2", true)]
        [InlineData("C2(NH2)2", true)]
        [InlineData("LiNC", false)]
        public void Should_contain_amino_group(string compoundSymbol, bool hasAminoGroup)
        {
            var compound = ChemicalCompound.New(compoundSymbol);

            Assert.Equal(compound.HasAminoGroup, hasAminoGroup);
        }

        [Theory]
        [InlineData("C6H5", true)]
        [InlineData("(C6H5)2", true)]
        [InlineData("C2(C6H5)2", true)]
        [InlineData("LiNC5H5", false)]
        public void Should_contain_phenyl_group(string compoundSymbol, bool hasPhenylGroup)
        {
            var compound = ChemicalCompound.New(compoundSymbol);

            Assert.Equal(compound.HasPhenylGroup, hasPhenylGroup);
        }
    }
}