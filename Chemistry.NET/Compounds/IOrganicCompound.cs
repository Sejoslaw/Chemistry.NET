/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Compounds
{
    public interface IOrganicCompound
    {
        /// <summary>
        /// Returns true if the current object is an Organic Compound; otherwise false.
        /// </summary>
        bool IsOrganic { get; }
    }
}
