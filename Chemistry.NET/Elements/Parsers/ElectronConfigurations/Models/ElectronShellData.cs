/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using Chemistry.NET.Elements.Models;

namespace Chemistry.NET.Elements.Parsers.ElectronConfigurations.Models
{
    /// <summary>
    /// Holds the information about an electron shell and a number of electrons in each subshell.
    /// </summary>
    public sealed class ElectronShellData
    {
        public ElectronShell Shell { get; internal set; }
        public IDictionary<ElectronSubShell, int> Subshells { get; internal set; } = new Dictionary<ElectronSubShell, int>();
    }
}
