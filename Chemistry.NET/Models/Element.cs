/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Definition of a standard element.
    /// </summary>
    public partial class Element
    {
        /// <summary>
        /// Atomic number of the element.
        /// </summary>
        /// <value></value>
        public int AtomicNumber { get; }
        /// <summary>
        /// Symbol of the element.
        /// </summary>
        /// <value></value>
        public string Symbol { get; }
        /// <summary>
        /// Fullname of the element.
        /// </summary>
        /// <value></value>
        public string Name { get; }
        /// <summary>
        /// Atomic weight of the element.
        /// </summary>
        /// <value></value>
        public double AtomicWeight { get; }
        /// <summary>
        /// Physical state of the element at 20 C (68 F).
        /// </summary>
        /// <value></value>
        public PhysicalState PhysicalState { get; }
        /// <summary>
        /// Type of the element.
        /// </summary>
        /// <value></value>
        public ElementType ElementType { get; }

        public Element(int atomicNumber, string symbol, string name, double atomicWeight, PhysicalState physicalState, ElementType elementType) // TODO: electron configuration
        {
            AtomicNumber = atomicNumber;
            Symbol = symbol;
            Name = name;
            AtomicWeight = atomicWeight;
            PhysicalState = physicalState;
            ElementType = elementType;
        }
    }
}