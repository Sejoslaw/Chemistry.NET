/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Models;
using Chemistry.NET.Parsers.Models;

namespace Chemistry.NET.Parsers
{
    /// <summary>
    /// Used for parsing Electron Configuration into separate Electron Subshells.
    /// </summary>
    public class ElectronConfigurationParser
    {
        /// <summary>
        /// Rules for parsing the configuration:
        ///     1. Subshells in configuration must be split with a space (' ').
        ///     2. Subshell chars letters must be written in lowercase.
        /// </summary>
        public IEnumerable<ElectronShellData> Parse(ElectronConfiguration config)
        {
            string[] subshellsDefinitions = config.Configuration.Split(' ');
            var subshells = new List<ElectronShellData>();

            foreach (string subshellDef in subshellsDefinitions)
            {
                ParseSubshell(subshells, subshellDef);
            }

            return subshells.AsReadOnly();
        }

        private void ParseSubshell(ICollection<ElectronShellData> subshells, string subshellDef)
        {
            // Shell

            var shellChar = subshellDef[0].ToString();
            var shellData = subshells.FirstOrDefault(s => s.Shell.QuantumNumber.ToString().Equals(shellChar) && char.IsUpper(s.Shell.ShellName[0]));

            if (shellData == null)
            {
                shellData = new ElectronShellData();
                shellData.Shell = Container.ElectronShells.FirstOrDefault(s => s.QuantumNumber.ToString().Equals(shellChar) && char.IsUpper(s.ShellName[0]));

                subshells.Add(shellData);
            }

            // Subshell

            var subshellChar = subshellDef[1].ToString();
            var subshell = Container.ElectronShells.FirstOrDefault(s => s.ShellName.Equals(subshellChar)) as ElectronSubShell;

            // Number Of Electrons

            var numberOfElectronsString = subshellDef.Substring(2);
            int numberOfElectrons = int.Parse(numberOfElectronsString);

            if (numberOfElectrons > subshell.GetMaxNumberOfElectrons())
            {
                throw new ArgumentException($"Invalid number of electrons on subshell: { subshellDef }", nameof(subshellDef));
            }

            // Adding to parsed objects

            shellData.Subshells.Add(subshell, numberOfElectrons);
        }
    }
}
