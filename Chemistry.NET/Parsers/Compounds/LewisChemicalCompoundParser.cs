/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Text;
using Chemistry.NET.Collections;
using Chemistry.NET.Extensions;

namespace Chemistry.NET.Parsers.Compounds
{
    /// <summary>
    /// Parser used for parsing Lewis representation of Chemical Compound.
    /// i.e. => H-O-H      =>    (H)2-O
    /// 
    /// i.e. => H   H
    ///         |   |
    ///         C = C      =>    (H)2-C=C-(H)2
    ///         |   |
    ///         H   H
    ///
    /// i.e. => H      H
    ///         |      |
    ///         C =--= C   =>    H-C|3|C-H  (simple idea of how the bond of 3 connections should be represented in code)
    ///             /\
    ///             This was used as a representation of triple (3) bond (just for visual idea).
    ///
    /// i.e. => A           H
    ///         |           |
    ///     A - B - C = D - C - H     =>   (A)2-B-(C=D-C-(H)2)-(E=F)
    ///         |                                             /\
    ///         E = F                                        Second brackets (")-'('") indicates that this is a new connection to "B" (atom before the previous brackets).
    ///
    /// In general "|number_of_connections|" represents the number of connections between 2 atoms.
    /// </summary>
    public class LewisChemicalCompoundParser : AbstractChemicalCompoundParser
    {
        protected override void WriteTree(StringBuilder builder, CompoundStack root)
        {
            throw new NotImplementedException("[W.I.P.] For now on please use CondensedChemicalCompoundParser");
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

                if (nextChar == ')' && currentIndex + 1 < input.Length)
                {
                    if (char.IsNumber(input[currentIndex + 1])) // We can have a number after closing bracket ')
                    {
                        currentIndex++;
                    }
                    else if (char.IsNumber(input[currentIndex + 2])) // We can have a number after line '|' which is after the closing bracket ')
                    {
                        currentIndex += 2;
                    }
                    
                    numberOfAtoms = GetFullNumber(input, ref currentIndex);
                }
                
                var stack = new ElementStack(currentChar.ToString().ToElement(), numberOfAtoms);
                AddStackToRoot(root, stack);
                ReadTree(input, root, ref currentIndex);
            }
            else if (char.IsLower(currentChar))
            {
                var numberOfAtoms = 1;
                var toMoveBack = 1;

                if ((nextChar == ')' || nextChar == '|') &&
                    currentIndex + 1 < input.Length)
                {
                    if (char.IsNumber(input[currentIndex + 1])) // We can have a number after closing bracket ')
                    {
                        currentIndex++;
                        toMoveBack = 3;
                    }
                    else if (char.IsNumber(input[currentIndex + 2])) // We can have a number after line '|' which is after the closing bracket ')
                    {
                        currentIndex += 2;
                        toMoveBack = 4;
                    }
                    
                    numberOfAtoms = GetFullNumber(input, ref currentIndex);
                }
                
                var previousChar = input[currentIndex - numberOfAtoms.ToString().Length - toMoveBack];
                var stack = new ElementStack($"{ previousChar }{ currentChar }".ToElement(), numberOfAtoms);
                AddStackToRoot(root, stack);
                
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
            else if (currentChar == '-' || currentChar == '=')
            {
                // Possible format's of chars next to the '-' or '='
                // Where: C - upper char; r - lower char; 0 - number;
                // C - (
                // ) - C
                // C - C
                // ) - (
                // 0 - (
                // 0 - C
                // r - (
                
                // For now on it will skip parsing the connections - not supported yet
                // There is no support (yet) of how to store the number of connections between atoms
                // This is something that will need to be added later on
                // TODO: Add support for storing the information about number of connections between atoms

                if (char.IsNumber(nextChar))
                {
                    while (input[currentIndex] != '|')
                    {
                        currentIndex++;
                    }
                }
                
                ReadTree(input, root, ref currentIndex);
            }
            else if (currentChar == '|')
            {
                // Possible format's of chars next to the '|'
                // Where: C - upper char; r - lower char; 0 - number;  
                // C | 0
                // r | 0
                // 0 | C
                // 0 | (
                
                // For now on it will skip parsing the number of connections - not supported yet
                // There is no support (yet) of how to store the number of connections between atoms
                // This is something that will need to be added later on
                // TODO: Add support for storing the information about number of connections between atoms

                if (char.IsNumber(nextChar))
                {
                    while (input[currentIndex] != '|')
                    {
                        currentIndex++;
                    }
                }
                
                ReadTree(input, root, ref currentIndex);
            }
            else
            {
                throw new FormatException($"Unknown char: '{ currentChar }', at position: { currentIndex }");
            }
        }

        private static void AddStackToRoot(CompoundStack root, ElementStack stack)
        {
            foreach (var node in root)
            {
                if (!(node is ElementStack elementStack) ||
                    elementStack.Element != stack.Element)
                {
                    continue;
                }
                
                elementStack.IncreaseStackSize();
                return;
            }
            
            root.Nodes.Add(stack);
        }
    }
}
