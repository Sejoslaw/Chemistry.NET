/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Hydrocarbons
{
    /// <summary>
    /// Describes an object to be a Hydrocarbon.
    /// </summary>
    public interface IHydrocarbon
    {
        /// <summary>
        /// Returns true if an object can be understand as Hydrocarbon; otherwise false.
        /// </summary>
        bool IsHydrocarbon { get; }
        /// <summary>
        /// Returns true if an object is an Alkane - acyclic saturated hydrocarbon; otherwise false.
        /// </summary>
        bool IsAlkane { get; }
        /// <summary>
        /// Returns true if an object is an Alkene - unsaturated hydrocarbon,
        /// that contains a carbon-carbon double bond; otherwise false.
        /// </summary>
        bool IsAlkene { get; }
        /// <summary>
        /// Returns true if an object is an Alkyne - unsaturated hydrocarbon,
        /// that contains a carbon-carbon triple bond; otherwise false.
        /// </summary>
        bool IsAlkyne { get; }
        /// <summary>
        /// Returns true if an object is a Cycloalkane - monocyclic saturated hydrocarbons; otherwise false.
        /// </summary>
        bool IsCycloalkane { get; }
        /// <summary>
        /// Returns true if an object is an Alkadiene - compound which contains 2 double bonds,
        /// usually among carbon atoms; otherwise false.
        /// </summary>
        bool IsAlkadiene { get; }
        /// <summary>
        /// Returns true if an object is Saturated - composed entirely of single bonds and saturated with hydrogen;
        /// otherwise false.
        /// </summary>
        bool IsSaturated { get; }
        /// <summary>
        /// Returns true if an object is Unsaturated - have 1+ double or triple bonds between carbon atoms;
        /// otherwise false.
        /// </summary>
        bool IsUnsaturated { get; }
    }
}
