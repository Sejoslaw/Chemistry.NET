/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Container for various types of the Elements.
    /// </summary>
    public static class ElementTypes
    {
        public static ElementType AlkaliMetal { get; } = new ElementType();
        public static ElementType AlkalineEarthMetal { get; } = new ElementType();
        public static ElementType TransitionMetal { get; } = new ElementType();
        public static ElementType BasicMetal { get; } = new ElementType();
        public static ElementType Metalloid { get; } = new ElementType();
        public static ElementType Nonmetal { get; } = new ElementType();
        public static ElementType Halogen { get; } = new ElementType();
        public static ElementType NobleGas { get; } = new ElementType();
        public static ElementType Lanthanide { get; } = new ElementType();
        public static ElementType Actinide { get; } = new ElementType();
        public static ElementType PostTransitionMetal { get; } = new ElementType();
    }
}