/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Container for known physical states of matter.
    /// </summary>
    public static class PhysicalStates
    {
        public static PhysicalState Solid { get; } = new PhysicalState();
        public static PhysicalState Liquid { get; } = new PhysicalState();
        public static PhysicalState Gas { get; } = new PhysicalState();
        public static PhysicalState Plasma { get; } = new PhysicalState();
        public static PhysicalState SyntheticallyPrepared { get; } = new PhysicalState();
        public static PhysicalState ExpectedToBeASolid { get; } = new PhysicalState();
        public static PhysicalState ExpectedToBeAGas { get; } = new PhysicalState();
    }
}
