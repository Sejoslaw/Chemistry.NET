/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Linq;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Common.Extensions
{
    public static class StringExtensions
    {
        public static Element ToElement(this string s)
        {
            return Container.Elements.FirstOrDefault(e => e.Symbol.Equals(s)) ?? throw new ArgumentException($"Unknown Element symbol: { s }");
        }
    }
}
