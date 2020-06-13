/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds;

namespace Chemistry.NET.Parsers.Compounds
{
    public abstract class AbstractChemicalCompoundParser : IChemicalCompoundParser
    {
        public abstract ChemicalCompound Read(string input);
        public abstract string Write(ChemicalCompound input);
    }
}
