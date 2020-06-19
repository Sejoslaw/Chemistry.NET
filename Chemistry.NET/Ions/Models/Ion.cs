/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Ions.Models
{
    /// <summary>
    /// Represents an Element with a net electrical charge.
    /// </summary>
    public class Ion
    {
        public IIonizable Ionizable { get; }
        public int OxidationState { get; }
        
        public Ion(IIonizable ionizable, int oxidationState)
        {
            Ionizable = ionizable;
            OxidationState = oxidationState;
        }
    }
}
