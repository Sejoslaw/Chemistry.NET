/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Container for known Periodic Table groups.
    /// </summary>
    public static class PeriodicTableGroups
    {
        public static PeriodicTableGroup Main { get; } = new PeriodicTableGroup();
        public static PeriodicTableGroup Lanthanide { get; } = new PeriodicTableGroup();
        public static PeriodicTableGroup Actinide { get; } = new PeriodicTableGroup();
    }
}
