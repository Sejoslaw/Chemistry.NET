/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds;

namespace Chemistry.NET.Parsers.Compounds
{
    /// <summary>
    /// Used for reading / writing data about Chemical Compound.
    /// </summary>
    public interface IChemicalCompoundParser
    {
        /// <summary>
        /// Reads Chemical Compound from the input string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        ChemicalCompound Read(string input);
        /// <summary>
        /// Writes Chemical Compound as an output string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        string Write(ChemicalCompound input);
    }
}
