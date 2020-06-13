/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Collections;
using Chemistry.NET.Models;
using Xunit;

namespace Chemistry.NET.Tests
{
    public class ObjectStackTests
    {
        [Theory]
        [InlineData(1, 10)]
        [InlineData(17, 123)]
        [InlineData(10, -9)]
        public void Should_add_objects_to_the_ObjectStack(int initialValue, int addToStack)
        {
            var stack = new ElementStack(Elements.Hydrogen, initialValue);
            stack.IncreaseStackSize(addToStack);
            Assert.Equal(stack.Count, initialValue + addToStack);
        }
    }
}
