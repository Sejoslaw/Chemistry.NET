/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>
namespace Chemistry.NET.Models
{
    /// <summary>
    /// Describes single shell of an Element.
    /// </summary>
    public partial class ElectronShell
    {
        public string ShellName { get; }
        public int QuantumNumber { get; }
        public ElectronSubShell[] SubShells { get; internal set; }

        public ElectronShell(string shellName, int quantumNumber)
        {
            ShellName = shellName;
            QuantumNumber = quantumNumber;
        }

        public virtual int GetMaxNumberOfElectrons()
        {
            return 2 * (QuantumNumber ^ 2);
        }

        internal ElectronShell AddSubshells(params ElectronSubShell[] subShells)
        {
            SubShells = subShells;
            return this;
        }
    }
}
