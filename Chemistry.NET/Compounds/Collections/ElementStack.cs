/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Compounds.Collections
{
    /// <summary>
    /// Represents and Stack of a single Element.
    /// </summary>
    public partial class ElementStack : IChemicalStack
    {
        /// <summary>
        /// Element stored on Stack.
        /// </summary>
        public Element Element { get; }
        public int Count { get; private set; }

        public ElementStack(Element element, int count = 1)
        {
            Element = element;
            Count = count;
        }
        
        /// <summary>
        /// Increases / Decreases the size of the current Stack.
        /// </summary>
        /// <param name="count"></param>
        public virtual void IncreaseStackSize(int count = 1)
        {
            Count += count;
        }
    }
}
