/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Describes single shell of an Element.
    /// </summary>
    public partial class ElectronShell
    {
        private static List<ElectronShell> _all;
        public static IEnumerable<ElectronShell> All
        {
            get
            {
                if (_all != null)
                {
                    return _all;
                }

                _all = new List<ElectronShell>();

                foreach (var property in typeof(ElectronShells).GetProperties())
                {
                    _all.Add(property.GetValue(null) as ElectronShell);
                }

                return _all.AsReadOnly();
            }
        }

        public string ShellName { get; }
        /// <summary>
        /// Quantum number 'n' user when ordering shells.
        /// For shells it starts with '1'
        /// For subshells it starts with '0'
        /// </summary>
        /// <value></value>
        public int QuantumNumber { get; }
        public ElectronShell[] SubShells { get; internal set; }

        public ElectronShell(string shellName, int quantumNumber)
        {
            ShellName = shellName;
            QuantumNumber = quantumNumber;
        }

        public virtual int GetMaxNumberOfElectrons()
        {
            return 2 * (QuantumNumber ^ 2);
        }

        internal ElectronShell AddSubshells(params ElectronShell[] subShells)
        {
            SubShells = subShells;
            return this;
        }
    }
}
