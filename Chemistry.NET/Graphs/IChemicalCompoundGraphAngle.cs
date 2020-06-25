/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Graphs
{
    /// <summary>
    /// Defines an angle between 2 connections.
    /// </summary>
    public interface IChemicalCompoundGraphAngle
    {
        /// <summary>
        /// Graph to which the current angle belongs.
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraph Graph { get; }
        /// <summary>
        /// First connection used to calculate the angle.
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraphConnection Connection1 { get; }
        /// <summary>
        /// Second connection used to calculate the angle.
        /// </summary>
        /// <value></value>
        IChemicalCompoundGraphConnection Connection2 { get; }
        /// <summary>
        /// Angle between the 2 connections.
        /// </summary>
        /// <value></value>
        double Angle { get; }
    }
}