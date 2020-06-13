/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds;

namespace Chemistry.NET.Parsers.Compounds
{
    /// <summary>
    /// Parser used for parsing Lewis representation of Chemical Compound.
    /// i.e. => H-O-H
    /// </summary>
    public class LewisChemicalCompoundParser : AbstractChemicalCompoundParser
    {
        public override ChemicalCompound Read(string input)
        {
            throw new System.NotImplementedException();
        }

        public override string Write(ChemicalCompound input)
        {
            throw new System.NotImplementedException();
        }
    }
}
