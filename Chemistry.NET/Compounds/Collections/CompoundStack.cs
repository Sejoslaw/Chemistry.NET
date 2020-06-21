/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Compounds.Collections
{
    /// <summary>
    /// Represents an information of how the Chemical Compound is build.
    /// </summary>
    public partial class CompoundStack : IChemicalStack, IEnumerable<IChemicalStack>
    {
        internal List<IChemicalStack> Nodes { get; } = new List<IChemicalStack>();
        public int Count { get; internal set; }
        
        public void IncreaseStackSize(int count = 1)
        {
            Count += count;
        }

        public IEnumerator<IChemicalStack> GetEnumerator()
        {
            return Nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public IEnumerable<ElementStack> GetAtoms()
        {
            var stacks = new List<ElementStack>();

            foreach (var node in Nodes)
            {
                if (node is ElementStack elementStack)
                {
                    AppendToAppropriateStack(stacks, elementStack);
                }
                else if (node is CompoundStack compoundStack)
                {
                    var innerStacks = compoundStack.GetAtoms();
                    innerStacks.ToList().ForEach(innerStack =>
                    {
                        if (compoundStack.Count > 1)
                        {
                            var newInnerStackCount = innerStack.Count * compoundStack.Count;
                            innerStack.IncreaseStackSize(- innerStack.Count);
                            innerStack.IncreaseStackSize(newInnerStackCount);
                        }
                        
                        AppendToAppropriateStack(stacks, innerStack);
                    });
                }
            }

            return stacks;
        }

        public bool AreAtomsCountEqual(IChemicalStack stack)
        {
            if (stack is ElementStack elementStack &&
                Nodes.Count == 1 &&
                Nodes[0] is ElementStack innerElementStack)
            {
                return innerElementStack.Equals(elementStack);
            }
            else if (stack is CompoundStack compoundStack)
            {
                return ContainsTheSameAtoms(compoundStack);
            }

            return false;
        }

        public bool ContainsTheSameAtoms(CompoundStack stack)
        {
            var atoms = GetAtoms();
            var stackAtoms = stack.GetAtoms();

            if (atoms.Count() != stackAtoms.Count())
            {
                return false;
            }

            foreach (var stackAtom in stackAtoms)
            {
                if (!ContainsTheSameAtom(atoms, stackAtom))
                {
                    return false;
                }
            }

            return true;
        }

        public bool ContainsTheSameAtom(IEnumerable<ElementStack> stacks, ElementStack elementStack)
        {
            foreach (var stack in stacks)
            {
                if (stack.Equals(elementStack))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetTotalElectronsCount()
        {
            return GetTotalCount(e => e.Structure.ElectronsCount);
        }

        public int GetTotalProtonsCount()
        {
            return GetTotalCount(e => e.Structure.ProtonsCount);
        }

        public int GetTotalNeutronsCount()
        {
            return GetTotalCount(e => e.Structure.NeutronsCount);
        }

        protected int GetTotalCount(Func<Element, int> func)
        {
            var total = 0;

            foreach (var node in Nodes)
            {
                if (node is ElementStack elementStack)
                {
                    total += func(elementStack.Element) * elementStack.Count;
                }
                else if (node is CompoundStack compoundStack)
                {
                    total += compoundStack.GetTotalCount(func);
                }
            }

            return total * Count;
        }

        private void AppendToAppropriateStack(List<ElementStack> stacks, ElementStack elementStack)
        {
            foreach (var stack in stacks)
            {
                if (stack.Element == elementStack.Element)
                {
                    stack.IncreaseStackSize(elementStack.Count);
                    return;
                }
            }

            stacks.Add(elementStack);
        }
    }
}
