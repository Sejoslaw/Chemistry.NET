/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Models
{
    /// <summary>
    /// Container for known Electron Shells.
    /// </summary>
    public static class ElectronShells
    {
        // Subshells

        public static ElectronSubShell SubShell_S { get; } = new ElectronSubShell("s", 0);
        public static ElectronSubShell SubShell_P { get; } = new ElectronSubShell("p", 1);
        public static ElectronSubShell SubShell_D { get; } = new ElectronSubShell("d", 2);
        public static ElectronSubShell SubShell_F { get; } = new ElectronSubShell("f", 3);
        public static ElectronSubShell SubShell_G { get; } = new ElectronSubShell("g", 4);
        public static ElectronSubShell SubShell_H { get; } = new ElectronSubShell("h", 5);
        public static ElectronSubShell SubShell_I { get; } = new ElectronSubShell("i", 6);

        // Shells

        public static ElectronShell Shell_K { get; } = new ElectronShell("K", 1).AddSubshells(SubShell_S);
        public static ElectronShell Shell_L { get; } = new ElectronShell("L", 2).AddSubshells(SubShell_S, SubShell_P);
        public static ElectronShell Shell_M { get; } = new ElectronShell("M", 3).AddSubshells(SubShell_S, SubShell_P, SubShell_D);
        public static ElectronShell Shell_N { get; } = new ElectronShell("N", 4).AddSubshells(SubShell_S, SubShell_P, SubShell_D, SubShell_F);
        public static ElectronShell Shell_O { get; } = new ElectronShell("O", 5).AddSubshells(SubShell_S, SubShell_P, SubShell_D, SubShell_F, SubShell_G);
        public static ElectronShell Shell_P { get; } = new ElectronShell("P", 6).AddSubshells(SubShell_S, SubShell_P, SubShell_D, SubShell_F, SubShell_G, SubShell_H);
        public static ElectronShell Shell_Q { get; } = new ElectronShell("Q", 7).AddSubshells(SubShell_S, SubShell_P, SubShell_D, SubShell_F, SubShell_G, SubShell_H, SubShell_I);
    }
}
