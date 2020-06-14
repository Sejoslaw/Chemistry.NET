/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Text;
using Chemistry.NET.Collections;
using Chemistry.NET.Compounds;

namespace Chemistry.NET.Parsers.Compounds
{
    public abstract class AbstractChemicalCompoundParser : IChemicalCompoundParser
    {
        public abstract ChemicalCompound Read(string input);
        public abstract string Write(ChemicalCompound input);

        /// <summary>
        /// Optional method which is used when writing Chemical Compound into string.
        /// </summary>
        /// <param name="builder"> Contains currently parsed Stacks. </param>
        /// <param name="stack"> Currently parsed Stack. Unknown to the library, could be User own implementation. </param>
        public virtual void WriteUnknownStack(StringBuilder builder, IChemicalStack stack)
        {
        }
    }
}
