/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Ions.Models
{
    /// <summary>
    /// Represents an Element with a net electrical charge.
    /// </summary>
    public class Ion
    {
        public Element Element { get; }
        public int OxidationState { get; }

        public Ion(Element element, int oxidationState)
        {
            Element = element;
            OxidationState = oxidationState;
        }
    }
}
