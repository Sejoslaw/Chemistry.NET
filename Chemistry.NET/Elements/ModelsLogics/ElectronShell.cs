/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    public partial class ElectronShell
    {
        public virtual int GetMaxNumberOfElectrons()
        {
            return 2 * (QuantumNumber ^ 2);
        }

        public virtual ElectronShell AddSubshells(params ElectronShell[] subShells)
        {
            SubShells = subShells;
            return this;
        }
    }
}
