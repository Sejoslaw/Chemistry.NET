/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Text;
using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Common.Extensions;

namespace Chemistry.NET.Compounds.Parsers.ChemicalCompounds
{
    /// <summary>
    /// Parser used for parsing condensed representation of Chemical Compound.
    /// i.e. => H2O or (H2)O or (CH3)2CHOH or CH(CH3)2OH
    /// </summary>
    public class CondensedChemicalCompoundParser : AbstractChemicalCompoundParser
    {
        protected override void WriteTree(StringBuilder builder, CompoundStack root)
        {
            foreach (var node in root.Nodes)
            {
                var numberOfAtoms = node.Count > 1 ? node.Count.ToString() : "";
                if (node is ElementStack elementStack)
                {
                    builder.Append($"{ elementStack.Element.Symbol }{ numberOfAtoms }");
                }
                else if (node is CompoundStack compoundStack)
                {
                    builder.Append("(");
                    WriteTree(builder, compoundStack);
                    builder.Append(")");
                    builder.Append(numberOfAtoms);
                }
                else
                {
                    WriteUnknownStack(builder, node);
                }
            }
        }

        protected override void ReadTree(string input, CompoundStack root, ref int currentIndex)
        {
            if (currentIndex >= input.Length)
            {
                return;
            }
            
            var currentChar = input[currentIndex];
            currentIndex++;
            var nextChar = currentIndex < input.Length ? input[currentIndex] : char.Parse("@");

            if (char.IsUpper(currentChar))
            {
                if (char.IsLower(nextChar))
                {
                    ReadTree(input, root, ref currentIndex);
                    return;
                }

                var numberOfAtoms = 1;

                if (char.IsNumber(nextChar))
                {
                    numberOfAtoms = GetFullNumber(input, ref currentIndex);
                }
                
                var stack = new ElementStack(currentChar.ToString().ToElement(), numberOfAtoms);
                root.Nodes.Add(stack);
                ReadTree(input, root, ref currentIndex);
            }
            else if (currentChar.Equals('('))
            {
                var stack = new CompoundStack();
                root.Nodes.Add(stack);
                InnerStacks.Push(stack);
                ReadTree(input, stack, ref currentIndex);
                ReadTree(input, InnerStacks.Peek(), ref currentIndex);
            }
            else if (currentChar.Equals(')'))
            {
                var numberOfAtoms = 1;
                
                if (char.IsNumber(nextChar))
                {
                    numberOfAtoms = GetFullNumber(input, ref currentIndex);
                }
                
                root.IncreaseStackSize(numberOfAtoms);
                InnerStacks.Pop();
            }
            else if (char.IsLower(currentChar))
            {
                var numberOfAtoms = 1;
                
                if (char.IsNumber(nextChar))
                {
                    numberOfAtoms = GetFullNumber(input, ref currentIndex);
                }

                var previousChar = GetPreviousUpperChar(input, currentIndex, numberOfAtoms);
                var stack = new ElementStack($"{ previousChar }{ currentChar }".ToElement(), numberOfAtoms);
                root.Nodes.Add(stack);
                ReadTree(input, root, ref currentIndex);
            }
            else if (char.IsNumber(currentChar) && currentIndex < 2) // Only for the number before the compound
            {
                currentIndex = 0;
                
                var numberOfMoles = GetFullNumber(input, ref currentIndex);

                if (input[currentIndex] == '(')
                {
                    currentIndex++;
                    numberOfMoles--;
                }
                
                root.Count = numberOfMoles;
                
                ReadTree(input, root, ref currentIndex);
            }
            else
            {
                throw new FormatException($"Unknown char: '{ currentChar }', at position: { currentIndex }");
            }
        }

        private char GetPreviousUpperChar(string input, in int currentIndex, in int numberOfAtoms)
        {
            var lastMinIndex = currentIndex - numberOfAtoms.ToString().Length;

            for (var i = lastMinIndex; i >= 0; --i)
            {
                if (char.IsUpper(input[i]))
                {
                    return input[i];
                }
            }
            
            throw new FormatException($"Cannot find last upper char for parameters: [Input: { input }, currentIndex: { currentIndex }, numberOfAtoms: { numberOfAtoms }]");
        }
    }
}
