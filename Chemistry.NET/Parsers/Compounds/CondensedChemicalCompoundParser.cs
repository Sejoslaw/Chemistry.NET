/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Text;
using Chemistry.NET.Collections;
using Chemistry.NET.Compounds;
using Chemistry.NET.Extensions;

namespace Chemistry.NET.Parsers.Compounds
{
    /// <summary>
    /// Parser used for parsing condensed representation of Chemical Compound.
    /// i.e. => H2O or (H2)O or (CH3)2CHOH or CH(CH3)2OH
    /// </summary>
    public class CondensedChemicalCompoundParser : AbstractChemicalCompoundParser
    {
        private Stack<CompoundStack> InnerStacks { get; } = new Stack<CompoundStack>();
        
        public override ChemicalCompound Read(string input)
        {
            var compound = new ChemicalCompound();
            compound.Stack.IncreaseStackSize();
            
            InnerStacks.Clear();
            InnerStacks.Push(compound.Stack);
            
            var index = 0;
            ReadTree(input, compound.Stack, ref index);
            
            return compound;
        }

        public override string Write(ChemicalCompound input)
        {
            throw new System.NotImplementedException();
        }

        private void ReadTree(string input, CompoundStack root, ref int currentIndex)
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
                    numberOfAtoms = GetNumberOfAtoms(input, ref currentIndex);
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
                    numberOfAtoms = GetNumberOfAtoms(input, ref currentIndex);
                }
                
                root.IncreaseStackSize(numberOfAtoms);
                InnerStacks.Pop();
            }
            else if (char.IsLower(currentChar))
            {
                var numberOfAtoms = 1;
                
                if (char.IsNumber(nextChar))
                {
                    numberOfAtoms = GetNumberOfAtoms(input, ref currentIndex);
                }

                var previousChar = input[currentIndex - 3];
                var stack = new ElementStack($"{ previousChar }{ currentChar }".ToElement(), numberOfAtoms);
                root.Nodes.Add(stack);
                ReadTree(input, root, ref currentIndex);
            }
            else
            {
                throw new FormatException($"Unknown char: '{ currentChar }', at position: { currentChar }");
            }
        }

        private static int GetNumberOfAtoms(string input, ref int currentIndex)
        {
            var builder = new StringBuilder();
            builder.Append(input[currentIndex].ToString());
            currentIndex++;

            while (currentIndex < input.Length && char.IsNumber(input[currentIndex]))
            {
                builder.Append(input[currentIndex]);
                currentIndex++;
            }

            var ret = builder.ToString();
            return int.Parse(ret);
        }
    }
}
