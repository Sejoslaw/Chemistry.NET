/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using System.Text;
using Chemistry.NET.Compounds.Collections;
using Chemistry.NET.Compounds.Models;

namespace Chemistry.NET.Compounds.Parsers.ChemicalCompounds
{
    public abstract class AbstractChemicalCompoundParser : IChemicalCompoundParser
    {
        protected Stack<CompoundStack> InnerStacks { get; } = new Stack<CompoundStack>();
        
        public virtual ChemicalCompound Read(string input)
        {
            var compound = new ChemicalCompound(input);
            compound.StructureTree.IncreaseStackSize();
            
            InnerStacks.Clear();
            InnerStacks.Push(compound.StructureTree);
            
            var index = 0;
            ReadTree(input, compound.StructureTree, ref index);
            
            return compound;
        }

        public virtual string Write(ChemicalCompound input)
        {
            var builder = new StringBuilder();
            
            if (input.StructureTree.Count > 1)
            {
                builder.Append(input.StructureTree.Count);
            }
            
            WriteTree(builder, input.StructureTree);
            return builder.ToString();
        }

        /// <summary>
        /// Optional method which is used when writing Chemical Compound into string.
        /// </summary>
        /// <param name="builder"> Contains currently parsed Stacks. </param>
        /// <param name="stack"> Currently parsed Stack. Unknown to the library, could be User own implementation. </param>
        protected virtual void WriteUnknownStack(StringBuilder builder, IChemicalStack stack)
        {
        }
        
        /// <summary>
        /// Returns the number of atoms starting from the specified index, and moves the index accordingly.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="startIndex"></param>
        /// <returns></returns>
        protected int GetFullNumber(string input, ref int startIndex)
        {
            var builder = new StringBuilder();
            builder.Append(input[startIndex].ToString());
            startIndex++;

            while (startIndex < input.Length && char.IsNumber(input[startIndex]))
            {
                builder.Append(input[startIndex]);
                startIndex++;
            }

            var ret = builder.ToString();
            return int.Parse(ret);
        }

        /// <summary>
        /// Parses given stack and serializes it into it's string representation.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="stack"></param>
        protected virtual void WriteTree(StringBuilder builder, CompoundStack stack)
        {
        }

        /// <summary>
        /// Builds a Compound structure tree from given input.
        /// </summary>
        /// <param name="input"></param>
        /// <param name="root"></param>
        /// <param name="currentIndex"></param>
        protected virtual void ReadTree(string input, CompoundStack root, ref int currentIndex)
        {
        }
    }
}
