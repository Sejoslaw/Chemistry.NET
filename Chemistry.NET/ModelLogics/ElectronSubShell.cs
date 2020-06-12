/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    public partial class ElectronSubShell
    {
        public override int GetMaxNumberOfElectrons()
        {
            return 4 * QuantumNumber + 2;
        }
    }
}
