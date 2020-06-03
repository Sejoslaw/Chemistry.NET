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
    public partial class ElectronSubShell : ElectronShell
    {
        public ElectronSubShell(string shellName, int quantumNumber) : base(shellName, quantumNumber)
        {
        }

        public override int GetMaxNumberOfElectrons()
        {
            return 4 * QuantumNumber + 2;
        }
    }
}