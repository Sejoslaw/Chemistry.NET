/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Definition of an element inside a Periodic Table.
    /// </summary>
    public class PeriodicTableElement
    {
        /// <summary>
        /// Element inside Periodic Table.
        /// </summary>
        /// <value></value>
        public Element Element { get; }
        /// <summary>
        /// Group of an Element.
        /// </summary>
        /// <value></value>
        public int Group { get; }
        /// <summary>
        /// Period of an Element.
        /// </summary>
        /// <value></value>
        public int Period { get; }
        /// <summary>
        /// Group to which the Element belongs.
        /// </summary>
        /// <value></value>
        public PeriodicTableGroup PeriodicTableGroup { get; }

        public PeriodicTableElement(Element element, int group, int period, PeriodicTableGroup periodicTableGroup)
        {
            Element = element;
            Group = group;
            Period = period;
            PeriodicTableGroup = periodicTableGroup;
        }
    }
}