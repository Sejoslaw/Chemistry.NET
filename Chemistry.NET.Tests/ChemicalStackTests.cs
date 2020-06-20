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
                Assert.Equal(stack.GetAtoms().Count(), 1);
            }
        }

        [Theory]
        [InlineData("H2O", 10, 8, 10, 2)]
        [InlineData("H2O2", 18, 16, 18, 2)]
        [InlineData("H(CH2)4", 33, 24, 33, 2)]
        public void Should_calculate_electrons_neutrons_protons_for_CompoundStack(string compoundSymbol, int electrons, int neutrons, int protons, int atoms)
        {
            var compound = ChemicalCompound.New(compoundSymbol, "");

            Assert.Equal(compound.GetTotalElectronsCount(), electrons);
            Assert.Equal(compound.GetTotalNeutronsCount(), neutrons);
            Assert.Equal(compound.GetTotalProtonsCount(), protons);
            Assert.Equal(compound.GetAtoms().Count(), atoms);
        }
    }
}