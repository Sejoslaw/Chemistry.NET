/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Extensions;
using Xunit;
using static Chemistry.NET.Constants;

namespace Chemistry.NET.Tests
{
    public class DaltonConvertionTests
    {
        [Theory]
        [InlineData(1, OneDalton)]
        [InlineData(2, OneDalton * 2)]
        [InlineData(3, OneDalton * 3)]
        [InlineData(4, OneDalton * 4)]
        [InlineData(5, OneDalton * 5)]
        [InlineData(1.5, OneDalton * 1.5)]
        public void If_converts_to_MeV_properly(double daltons, double mev)
        {
            Assert.Equal(daltons.ToMeV(), mev);
        }

        [Theory]
        [InlineData(1, OneDalton)]
        [InlineData(2, OneDalton * 2)]
        [InlineData(3, OneDalton * 3)]
        [InlineData(4, OneDalton * 4)]
        [InlineData(5, OneDalton * 5)]
        [InlineData(1.5, OneDalton * 1.5)]
        public void If_converts_to_Dalton_properly(double daltons, double mev)
        {
            Assert.Equal(daltons, mev.ToDaltons());
        }
    }
}