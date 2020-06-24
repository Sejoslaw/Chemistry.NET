/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Compounds.Collections
{
    /// <summary>
    /// Represents and Stack of a single Element.
    /// </summary>
    public partial class ElementStack : IChemicalStack, IEquatable<ElementStack>
    {
        /// <summary>
        /// Element stored on Stack.
        /// </summary>
        public Element Element { get; }
        public int Count { get; private set; }
        public Guid StackId { get; } = Guid.NewGuid();

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

        public int GetTotalElectronsCount()
        {
            return Element.Structure.ElectronsCount * Count;
        }

        public int GetTotalProtonsCount()
        {
            return Element.Structure.ProtonsCount * Count;
        }

        public int GetTotalNeutronsCount()
        {
            return Element.Structure.NeutronsCount * Count;
        }

        public IEnumerable<ElementStack> GetAtoms()
        {
            yield return this;
        }

        public bool AreAtomsCountEqual(IChemicalStack stack)
        {
            if (stack is ElementStack elementStack)
            {
                return Equals(elementStack);
            }
            else if (stack is CompoundStack compoundStack && 
                     compoundStack.Nodes.Count == 1 && 
                     compoundStack.Nodes[0] is ElementStack innerElementStack)
            {
                return Equals(innerElementStack);
            }

            return false;
        }

        public bool ContainsBond(params Element[] elements)
        {
            // ElementStack contains always only one Element so there are no bonds anyway.
            return false;
        }

        public bool Equals(ElementStack other)
        {
            return Element == other.Element && Count == other.Count;
        }
    }
}
