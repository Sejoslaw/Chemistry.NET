/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Ions
{
    /// <summary>
    /// Describes an object which can be ionized.
    /// </summary>
    public interface IIonizable
    {
        /// <summary>
        /// True if the current Ion is an Anion.
        /// </summary>
        bool IsAnion { get; }
        /// <summary>
        /// True if the current Ion is an Cation.
        /// </summary>
        bool IsCation { get; }
        /// <summary>
        /// True if this ionized object consist of exactly 1 atom.
        /// </summary>
        bool IsMonatomic { get; }
        /// <summary>
        /// True if this ionized object consist of 2+ atoms.
        /// </summary>
        bool IsPolyatomic { get; }
    }
}
