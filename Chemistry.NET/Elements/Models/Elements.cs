/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Common.Extensions;

namespace Chemistry.NET.Elements.Models
{
    /// <summary>
    /// Container for known Elements.
    /// </summary>
    public static class Elements
    {
        // Couple additional commonly used Isotopes
        public static Element Deuterium { get; } = new Element(0, "D", "Deuterium", (2.01410177811).ToMeV(), "FFFFFF", new ElectronConfiguration("1s1"), "2.2", "120", "13.598", "0.754", "+1, -1", PhysicalStates.Gas, "13.81", "20.28", "0.00008988", null, 1931, ElementStructures.Deuterium);
        public static Element Tritium { get; } = new Element(0, "T", "Tritium", (3.0160492).ToMeV(), "FFFFFF", new ElectronConfiguration("1s1"), "2.2", "120", "13.598", "0.754", "+1, -1", PhysicalStates.Gas, "13.81", "20.28", "0.00008988", null, 1934, ElementStructures.Tritium);
        
        // Core Elements
        public static Element Hydrogen { get; } = new Element(1, "H", "Hydrogen", 1.008, "FFFFFF", new ElectronConfiguration("1s1"), "2.2", "120", "13.598", "0.754", "+1, -1", PhysicalStates.Gas, "13.81", "20.28", "0.00008988", ElementTypes.Nonmetal, 1766, ElementStructures.Hydrogen);
        public static Element Helium { get; } = new Element(2, "He", "Helium", 4.0026, "D9FFFF", new ElectronConfiguration("1s2"), "", "140", "24.587", "", "0", PhysicalStates.Gas, "0.95", "4.22", "0.0001785", ElementTypes.NobleGas, 1868, ElementStructures.Helium);
        public static Element Lithium { get; } = new Element(3, "Li", "Lithium", 7, "CC80FF", new ElectronConfiguration("1s2 2s1"), "0.98", "182", "5.392", "0.618", "+1", PhysicalStates.Solid, "453.65", "1615", "0.534", ElementTypes.AlkaliMetal, 1817, ElementStructures.Lithium);
        public static Element Beryllium { get; } = new Element(4, "Be", "Beryllium", 9.012183, "C2FF00", new ElectronConfiguration("1s2 2s2"), "1.57", "153", "9.323", "", "+2", PhysicalStates.Solid, "1560", "2744", "1.85", ElementTypes.AlkalineEarthMetal, 1798, ElementStructures.Beryllium);
        public static Element Boron { get; } = new Element(5, "B", "Boron", 10.81, "FFB5B5", new ElectronConfiguration("1s2 2s2 2p1"), "2.04", "192", "8.298", "0.277", "+3", PhysicalStates.Solid, "2348", "4273", "2.37", ElementTypes.Metalloid, 1808, ElementStructures.Boron);
        public static Element Carbon { get; } = new Element(6, "C", "Carbon", 12.011, "909090", new ElectronConfiguration("1s2 2s2 2p2"), "2.55", "170", "11.260", "1.263", "+4, +2, -4", PhysicalStates.Solid, "3823", "4098", "2.2670", ElementTypes.Nonmetal, -2147483648, ElementStructures.Carbon);
        public static Element Nitrogen { get; } = new Element(7, "N", "Nitrogen", 14.007, "3050F8", new ElectronConfiguration("1s2 2s2 2p3"), "3.04", "155", "14.534", "", "+5, +4, +3, +2, +1, -1, -2, -3", PhysicalStates.Gas, "63.15", "77.36", "0.0012506", ElementTypes.Nonmetal, 1772, ElementStructures.Nitrogen);
        public static Element Oxygen { get; } = new Element(8, "O", "Oxygen", 15.999, "FF0D0D", new ElectronConfiguration("1s2 2s2 2p4"), "3.44", "152", "13.618", "1.461", "-2", PhysicalStates.Gas, "54.36", "90.2", "0.001429", ElementTypes.Nonmetal, 1774, ElementStructures.Oxygen);
        public static Element Fluorine { get; } = new Element(9, "F", "Fluorine", 18.99840316, "90E050", new ElectronConfiguration("1s2 2s2 2p5"), "3.98", "135", "17.423", "3.339", "-1", PhysicalStates.Gas, "53.53", "85.03", "0.001696", ElementTypes.Halogen, 1670, ElementStructures.Fluorine);
        public static Element Neon { get; } = new Element(10, "Ne", "Neon", 20.18, "B3E3F5", new ElectronConfiguration("1s2 2s2 2p6"), "", "154", "21.565", "", "0", PhysicalStates.Gas, "24.56", "27.07", "0.0008999", ElementTypes.NobleGas, 1898, ElementStructures.Neon);
        public static Element Sodium { get; } = new Element(11, "Na", "Sodium", 22.9897693, "AB5CF2", new ElectronConfiguration("1s2 2s2 2p6 3s1"), "0.93", "227", "5.139", "0.548", "+1", PhysicalStates.Solid, "370.95", "1156", "0.97", ElementTypes.AlkaliMetal, 1807, ElementStructures.Sodium);
        public static Element Magnesium { get; } = new Element(12, "Mg", "Magnesium", 24.305, "8AFF00", new ElectronConfiguration("1s2 2s2 2p6 3s2"), "1.31", "173", "7.646", "", "+2", PhysicalStates.Solid, "923", "1363", "1.74", ElementTypes.AlkalineEarthMetal, 1808, ElementStructures.Magnesium);
        public static Element Aluminum { get; } = new Element(13, "Al", "Aluminum", 26.981538, "BFA6A6", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p1"), "1.61", "184", "5.986", "0.441", "+3", PhysicalStates.Solid, "933.437", "2792", "2.70", ElementTypes.PostTransitionMetal, -2147483648, ElementStructures.Aluminum);
        public static Element Silicon { get; } = new Element(14, "Si", "Silicon", 28.085, "F0C8A0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p2"), "1.9", "210", "8.152", "1.385", "+4, +2, -4", PhysicalStates.Solid, "1687", "3538", "2.3296", ElementTypes.Metalloid, 1854, ElementStructures.Silicon);
        public static Element Phosphorus { get; } = new Element(15, "P", "Phosphorus", 30.973762, "FF8000", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p3"), "2.19", "180", "10.487", "0.746", "+5, +3, -3", PhysicalStates.Solid, "317.3", "553.65", "1.82", ElementTypes.Nonmetal, 1669, ElementStructures.Phosphorus);
        public static Element Sulfur { get; } = new Element(16, "S", "Sulfur", 32.07, "FFFF30", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p4"), "2.58", "180", "10.360", "2.077", "+6, +4, -2", PhysicalStates.Solid, "388.36", "717.75", "2.067", ElementTypes.Nonmetal, -2147483648, ElementStructures.Sulfur);
        public static Element Chlorine { get; } = new Element(17, "Cl", "Chlorine", 35.45, "1FF01F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p5"), "3.16", "175", "12.968", "3.617", "+7, +5, +1, -1", PhysicalStates.Gas, "171.65", "239.11", "0.003214", ElementTypes.Halogen, 1774, ElementStructures.Chlorine);
        public static Element Argon { get; } = new Element(18, "Ar", "Argon", 39.9, "80D1E3", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6"), "", "188", "15.760", "", "0", PhysicalStates.Gas, "83.8", "87.3", "0.0017837", ElementTypes.NobleGas, 1894, ElementStructures.Argon);
        public static Element Potassium { get; } = new Element(19, "K", "Potassium", 39.098, "8F40D4", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s1"), "0.82", "275", "4.341", "0.501", "+1", PhysicalStates.Solid, "336.53", "1032", "0.89", ElementTypes.AlkaliMetal, 1807, ElementStructures.Potassium);
        public static Element Calcium { get; } = new Element(20, "Ca", "Calcium", 40.08, "3DFF00", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2"), "1", "231", "6.113", "", "+2", PhysicalStates.Solid, "1115", "1757", "1.54", ElementTypes.AlkalineEarthMetal, -2147483648, ElementStructures.Calcium);
        public static Element Scandium { get; } = new Element(21, "Sc", "Scandium", 44.95591, "E6E6E6", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d1"), "1.36", "211", "6.561", "0.188", "+3", PhysicalStates.Solid, "1814", "3109", "2.99", ElementTypes.TransitionMetal, 1879, ElementStructures.Scandium);
        public static Element Titanium { get; } = new Element(22, "Ti", "Titanium", 47.87, "BFC2C7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d2"), "1.54", "187", "6.828", "0.079", "+4, +3, +2", PhysicalStates.Solid, "1941", "3560", "4.5", ElementTypes.TransitionMetal, 1791, ElementStructures.Titanium);
        public static Element Vanadium { get; } = new Element(23, "V", "Vanadium", 50.941, "A6A6AB", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d3"), "1.63", "179", "6.746", "0.525", "+5, +4, +3, +2", PhysicalStates.Solid, "2183", "3680", "6.0", ElementTypes.TransitionMetal, 1801, ElementStructures.Vanadium);
        public static Element Chromium { get; } = new Element(24, "Cr", "Chromium", 51.996, "8A99C7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 3d5 4s1"), "1.66", "189", "6.767", "0.666", "+6, +3, +2", PhysicalStates.Solid, "2180", "2944", "7.15", ElementTypes.TransitionMetal, 1797, ElementStructures.Chromium);
        public static Element Manganese { get; } = new Element(25, "Mn", "Manganese", 54.93804, "9C7AC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d5"), "1.55", "197", "7.434", "", "+7, +4, +3, +2", PhysicalStates.Solid, "1519", "2334", "7.3", ElementTypes.TransitionMetal, 1774, ElementStructures.Manganese);
        public static Element Iron { get; } = new Element(26, "Fe", "Iron", 55.84, "E06633", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d6"), "1.83", "194", "7.902", "0.163", "+3, +2", PhysicalStates.Solid, "1811", "3134", "7.874", ElementTypes.TransitionMetal, -2147483648, ElementStructures.Iron);
        public static Element Cobalt { get; } = new Element(27, "Co", "Cobalt", 58.93319, "F090A0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d7"), "1.88", "192", "7.881", "0.661", "+3, +2", PhysicalStates.Solid, "1768", "3200", "8.86", ElementTypes.TransitionMetal, 1735, ElementStructures.Cobalt);
        public static Element Nickel { get; } = new Element(28, "Ni", "Nickel", 58.693, "50D050", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d8"), "1.91", "163", "7.640", "1.156", "+3, +2", PhysicalStates.Solid, "1728", "3186", "8.912", ElementTypes.TransitionMetal, 1751, ElementStructures.Nickel);
        public static Element Copper { get; } = new Element(29, "Cu", "Copper", 63.55, "C88033", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s1 3d10"), "1.9", "140", "7.726", "1.228", "+2, +1", PhysicalStates.Solid, "1357.77", "2835", "8.933", ElementTypes.TransitionMetal, -2147483648, ElementStructures.Copper);
        public static Element Zinc { get; } = new Element(30, "Zn", "Zinc", 65.4, "7D80B0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10"), "1.65", "139", "9.394", "", "+2", PhysicalStates.Solid, "692.68", "1180", "7.134", ElementTypes.TransitionMetal, 1746, ElementStructures.Zinc);
        public static Element Gallium { get; } = new Element(31, "Ga", "Gallium", 69.72, "C28F8F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p1"), "1.81", "187", "5.999", "0.3", "+3", PhysicalStates.Solid, "302.91", "2477", "5.91", ElementTypes.PostTransitionMetal, 1875, ElementStructures.Gallium);
        public static Element Germanium { get; } = new Element(32, "Ge", "Germanium", 72.63, "668F8F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p2"), "2.01", "211", "7.900", "1.35", "+4, +2", PhysicalStates.Solid, "1211.4", "3106", "5.323", ElementTypes.Metalloid, 1886, ElementStructures.Germanium);
        public static Element Arsenic { get; } = new Element(33, "As", "Arsenic", 74.92159, "BD80E3", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p3"), "2.18", "185", "9.815", "0.81", "+5, +3, -3", PhysicalStates.Solid, "1090", "887", "5.776", ElementTypes.Metalloid, -2147483648, ElementStructures.Arsenic);
        public static Element Selenium { get; } = new Element(34, "Se", "Selenium", 78.97, "FFA100", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p4"), "2.55", "190", "9.752", "2.021", "+6, +4, -2", PhysicalStates.Solid, "493.65", "958", "4.809", ElementTypes.Nonmetal, 1817, ElementStructures.Selenium);
        public static Element Bromine { get; } = new Element(35, "Br", "Bromine", 79.9, "A62929", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p5"), "2.96", "183", "11.814", "3.365", "+5, +1, -1", PhysicalStates.Liquid, "265.95", "331.95", "3.11", ElementTypes.Halogen, 1826, ElementStructures.Bromine);
        public static Element Krypton { get; } = new Element(36, "Kr", "Krypton", 83.8, "5CB8D1", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6"), "3", "202", "14.000", "", "0", PhysicalStates.Gas, "115.79", "119.93", "0.003733", ElementTypes.NobleGas, 1898, ElementStructures.Krypton);
        public static Element Rubidium { get; } = new Element(37, "Rb", "Rubidium", 85.468, "702EB0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1"), "0.82", "303", "4.177", "0.468", "+1", PhysicalStates.Solid, "312.46", "961", "1.53", ElementTypes.AlkaliMetal, 1861, ElementStructures.Rubidium);
        public static Element Strontium { get; } = new Element(38, "Sr", "Strontium", 87.6, "00FF00", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2"), "0.95", "249", "5.695", "", "+2", PhysicalStates.Solid, "1050", "1655", "2.64", ElementTypes.AlkalineEarthMetal, 1790, ElementStructures.Strontium);
        public static Element Yttrium { get; } = new Element(39, "Y", "Yttrium", 88.9058, "94FFFF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d1"), "1.22", "219", "6.217", "0.307", "+3", PhysicalStates.Solid, "1795", "3618", "4.47", ElementTypes.TransitionMetal, 1794, ElementStructures.Yttrium);
        public static Element Zirconium { get; } = new Element(40, "Zr", "Zirconium", 91.22, "94E0E0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d2"), "1.33", "186", "6.634", "0.426", "+4", PhysicalStates.Solid, "2128", "4682", "6.52", ElementTypes.TransitionMetal, 1789, ElementStructures.Zirconium);
        public static Element Niobium { get; } = new Element(41, "Nb", "Niobium", 92.9064, "73C2C9", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d4"), "1.6", "207", "6.759", "0.893", "+5, +3", PhysicalStates.Solid, "2750", "5017", "8.57", ElementTypes.TransitionMetal, 1801, ElementStructures.Niobium);
        public static Element Molybdenum { get; } = new Element(42, "Mo", "Molybdenum", 96, "54B5B5", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d5"), "2.16", "209", "7.092", "0.746", "+6", PhysicalStates.Solid, "2896", "4912", "10.2", ElementTypes.TransitionMetal, 1778, ElementStructures.Molybdenum);
        public static Element Technetium { get; } = new Element(43, "Tc", "Technetium", 97.90721, "3B9E9E", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d5"), "1.9", "209", "7.28", "0.55", "+7, +6, +4", PhysicalStates.Solid, "2430", "4538", "11", ElementTypes.TransitionMetal, 1937, ElementStructures.Technetium);
        public static Element Ruthenium { get; } = new Element(44, "Ru", "Ruthenium", 101.1, "248F8F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d7"), "2.2", "207", "7.361", "1.05", "+3", PhysicalStates.Solid, "2607", "4423", "12.1", ElementTypes.TransitionMetal, 1827, ElementStructures.Ruthenium);
        public static Element Rhodium { get; } = new Element(45, "Rh", "Rhodium", 102.9055, "0A7D8C", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d8"), "2.28", "195", "7.459", "1.137", "+3", PhysicalStates.Solid, "2237", "3968", "12.4", ElementTypes.TransitionMetal, 1803, ElementStructures.Rhodium);
        public static Element Palladium { get; } = new Element(46, "Pd", "Palladium", 106.4, "6985", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 4d10"), "2.2", "202", "8.337", "0.557", "+3, +2", PhysicalStates.Solid, "1828.05", "3236", "12.0", ElementTypes.TransitionMetal, 1803, ElementStructures.Palladium);
        public static Element Silver { get; } = new Element(47, "Ag", "Silver", 107.868, "C0C0C0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s1 4d10"), "1.93", "172", "7.576", "1.302", "+1", PhysicalStates.Solid, "1234.93", "2435", "10.501", ElementTypes.TransitionMetal, -2147483648, ElementStructures.Silver);
        public static Element Cadmium { get; } = new Element(48, "Cd", "Cadmium", 112.41, "FFD98F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10"), "1.69", "158", "8.994", "", "+2", PhysicalStates.Solid, "594.22", "1040", "8.69", ElementTypes.TransitionMetal, 1817, ElementStructures.Cadmium);
        public static Element Indium { get; } = new Element(49, "In", "Indium", 114.82, "A67573", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p1"), "1.78", "193", "5.786", "0.3", "+3", PhysicalStates.Solid, "429.75", "2345", "7.31", ElementTypes.PostTransitionMetal, 1863, ElementStructures.Indium);
        public static Element Tin { get; } = new Element(50, "Sn", "Tin", 118.71, "668080", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p2"), "1.96", "217", "7.344", "1.2", "+4, +2", PhysicalStates.Solid, "505.08", "2875", "7.287", ElementTypes.PostTransitionMetal, -2147483648, ElementStructures.Tin);
        public static Element Antimony { get; } = new Element(51, "Sb", "Antimony", 121.76, "9E63B5", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p3"), "2.05", "206", "8.64", "1.07", "+5, +3, -3", PhysicalStates.Solid, "903.78", "1860", "6.685", ElementTypes.Metalloid, -2147483648, ElementStructures.Antimony);
        public static Element Tellurium { get; } = new Element(52, "Te", "Tellurium", 127.6, "D47A00", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p4"), "2.1", "206", "9.010", "1.971", "+6, +4, -2", PhysicalStates.Solid, "722.66", "1261", "6.232", ElementTypes.Metalloid, 1782, ElementStructures.Tellurium);
        public static Element Iodine { get; } = new Element(53, "I", "Iodine", 126.9045, "940094", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p5"), "2.66", "198", "10.451", "3.059", "+7, +5, +1, -1", PhysicalStates.Solid, "386.85", "457.55", "4.93", ElementTypes.Halogen, 1811, ElementStructures.Iodine);
        public static Element Xenon { get; } = new Element(54, "Xe", "Xenon", 131.29, "429EB0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6"), "2.6", "216", "12.130", "", "0", PhysicalStates.Gas, "161.36", "165.03", "0.005887", ElementTypes.NobleGas, 1898, ElementStructures.Xenon);
        public static Element Cesium { get; } = new Element(55, "Cs", "Cesium", 132.905452, "57178F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s1"), "0.79", "343", "3.894", "0.472", "+1", PhysicalStates.Solid, "301.59", "944", "1.93", ElementTypes.AlkaliMetal, 1860, ElementStructures.Cesium);
        public static Element Barium { get; } = new Element(56, "Ba", "Barium", 137.33, "00C900", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2"), "0.89", "268", "5.212", "", "+2", PhysicalStates.Solid, "1000", "2170", "3.62", ElementTypes.AlkalineEarthMetal, 1808, ElementStructures.Barium);
        public static Element Lanthanum { get; } = new Element(57, "La", "Lanthanum", 138.9055, "70D4FF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 5d1"), "1.1", "240", "5.577", "0.5", "+3", PhysicalStates.Solid, "1191", "3737", "6.15", ElementTypes.Lanthanide, 1839, ElementStructures.Lanthanum);
        public static Element Cerium { get; } = new Element(58, "Ce", "Cerium", 140.12, "FFFFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f1 5d1"), "1.12", "235", "5.539", "0.5", "+4, +3", PhysicalStates.Solid, "1071", "3697", "6.770", ElementTypes.Lanthanide, 1803, ElementStructures.Cerium);
        public static Element Praseodymium { get; } = new Element(59, "Pr", "Praseodymium", 140.9077, "D9FFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f3"), "1.13", "239", "5.464", "", "+3", PhysicalStates.Solid, "1204", "3793", "6.77", ElementTypes.Lanthanide, 1885, ElementStructures.Praseodymium);
        public static Element Neodymium { get; } = new Element(60, "Nd", "Neodymium", 144.24, "C7FFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f4"), "1.14", "229", "5.525", "", "+3", PhysicalStates.Solid, "1294", "3347", "7.01", ElementTypes.Lanthanide, 1885, ElementStructures.Neodymium);
        public static Element Promethium { get; } = new Element(61, "Pm", "Promethium", 144.91276, "A3FFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f5"), "", "236", "5.55", "", "+3", PhysicalStates.Solid, "1315", "3273", "7.26", ElementTypes.Lanthanide, 1945, ElementStructures.Promethium);
        public static Element Samarium { get; } = new Element(62, "Sm", "Samarium", 150.4, "8FFFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f6"), "1.17", "229", "5.644", "", "+3, +2", PhysicalStates.Solid, "1347", "2067", "7.52", ElementTypes.Lanthanide, 1879, ElementStructures.Samarium);
        public static Element Europium { get; } = new Element(63, "Eu", "Europium", 151.96, "61FFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f7"), "", "233", "5.670", "", "+3, +2", PhysicalStates.Solid, "1095", "1802", "5.24", ElementTypes.Lanthanide, 1901, ElementStructures.Europium);
        public static Element Gadolinium { get; } = new Element(64, "Gd", "Gadolinium", 157.2, "45FFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f7 5d1"), "1.2", "237", "6.150", "", "+3", PhysicalStates.Solid, "1586", "3546", "7.90", ElementTypes.Lanthanide, 1880, ElementStructures.Gadolinium);
        public static Element Terbium { get; } = new Element(65, "Tb", "Terbium", 158.92535, "30FFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f9"), "", "221", "5.864", "", "+3", PhysicalStates.Solid, "1629", "3503", "8.23", ElementTypes.Lanthanide, 1843, ElementStructures.Terbium);
        public static Element Dysprosium { get; } = new Element(66, "Dy", "Dysprosium", 162.5, "1FFFC7", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f10"), "1.22", "229", "5.939", "", "+3", PhysicalStates.Solid, "1685", "2840", "8.55", ElementTypes.Lanthanide, 1886, ElementStructures.Dysprosium);
        public static Element Holmium { get; } = new Element(67, "Ho", "Holmium", 164.93033, "00FF9C", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f11"), "1.23", "216", "6.022", "", "+3", PhysicalStates.Solid, "1747", "2973", "8.80", ElementTypes.Lanthanide, 1878, ElementStructures.Holmium);
        public static Element Erbium { get; } = new Element(68, "Er", "Erbium", 167.26, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f12"), "1.24", "235", "6.108", "", "+3", PhysicalStates.Solid, "1802", "3141", "9.07", ElementTypes.Lanthanide, 1843, ElementStructures.Erbium);
        public static Element Thulium { get; } = new Element(69, "Tm", "Thulium", 168.93422, "00D452", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f13"), "1.25", "227", "6.184", "", "+3", PhysicalStates.Solid, "1818", "2223", "9.32", ElementTypes.Lanthanide, 1879, ElementStructures.Thulium);
        public static Element Ytterbium { get; } = new Element(70, "Yb", "Ytterbium", 173.04, "00BF38", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14"), "", "242", "6.254", "", "+3, +2", PhysicalStates.Solid, "1092", "1469", "6.90", ElementTypes.Lanthanide, 1878, ElementStructures.Ytterbium);
        public static Element Lutetium { get; } = new Element(71, "Lu", "Lutetium", 174.967, "00AB24", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d1"), "1.27", "221", "5.426", "", "+3", PhysicalStates.Solid, "1936", "3675", "9.84", ElementTypes.Lanthanide, 1907, ElementStructures.Lutetium);
        public static Element Hafnium { get; } = new Element(72, "Hf", "Hafnium", 178.5, "4DC2FF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d2"), "1.3", "212", "6.825", "", "+4", PhysicalStates.Solid, "2506", "4876", "13.3", ElementTypes.TransitionMetal, 1923, ElementStructures.Hafnium);
        public static Element Tantalum { get; } = new Element(73, "Ta", "Tantalum", 180.9479, "4DA6FF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d3"), "1.5", "217", "7.89", "0.322", "+5", PhysicalStates.Solid, "3290", "5731", "16.4", ElementTypes.TransitionMetal, 1802, ElementStructures.Tantalum);
        public static Element Tungsten { get; } = new Element(74, "W", "Tungsten", 183.8, "2194D6", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d4"), "2.36", "210", "7.98", "0.815", "+6", PhysicalStates.Solid, "3695", "5828", "19.3", ElementTypes.TransitionMetal, 1783, ElementStructures.Tungsten);
        public static Element Rhenium { get; } = new Element(75, "Re", "Rhenium", 186.21, "267DAB", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d5"), "1.9", "217", "7.88", "0.15", "+7, +6, +4", PhysicalStates.Solid, "3459", "5869", "20.8", ElementTypes.TransitionMetal, 1925, ElementStructures.Rhenium);
        public static Element Osmium { get; } = new Element(76, "Os", "Osmium", 190.2, "266696", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d6"), "2.2", "216", "8.7", "1.1", "+4, +3", PhysicalStates.Solid, "3306", "5285", "22.57", ElementTypes.TransitionMetal, 1803, ElementStructures.Osmium);
        public static Element Iridium { get; } = new Element(77, "Ir", "Iridium", 192.22, "175487", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d7"), "2.2", "202", "9.1", "1.565", "+4, +3", PhysicalStates.Solid, "2719", "4701", "22.42", ElementTypes.TransitionMetal, 1803, ElementStructures.Iridium);
        public static Element Platinum { get; } = new Element(78, "Pt", "Platinum", 195.08, "D0D0E0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s1 4f14 5d9"), "2.28", "209", "9", "2.128", "+4, +2", PhysicalStates.Solid, "2041.55", "4098", "21.46", ElementTypes.TransitionMetal, 1735, ElementStructures.Platinum);
        public static Element Gold { get; } = new Element(79, "Au", "Gold", 196.96657, "FFD123", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s1 4f14 5d10"), "2.54", "166", "9.226", "2.309", "+3, +1", PhysicalStates.Solid, "1337.33", "3129", "19.282", ElementTypes.TransitionMetal, -2147483648, ElementStructures.Gold);
        public static Element Mercury { get; } = new Element(80, "Hg", "Mercury", 200.59, "B8B8D0", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10"), "2", "209", "10.438", "", "+2, +1", PhysicalStates.Liquid, "234.32", "629.88", "13.5336", ElementTypes.TransitionMetal, -2147483648, ElementStructures.Mercury);
        public static Element Thallium { get; } = new Element(81, "Tl", "Thallium", 204.383, "A6544D", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p1"), "1.62", "196", "6.108", "0.2", "+3, +1", PhysicalStates.Solid, "577", "1746", "11.8", ElementTypes.PostTransitionMetal, 1861, ElementStructures.Thallium);
        public static Element Lead { get; } = new Element(82, "Pb", "Lead", 207, "575961", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p2"), "2.33", "202", "7.417", "0.36", "+4, +2", PhysicalStates.Solid, "600.61", "2022", "11.342", ElementTypes.PostTransitionMetal, -2147483648, ElementStructures.Lead);
        public static Element Bismuth { get; } = new Element(83, "Bi", "Bismuth", 208.9804, "9E4FB5", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p3"), "2.02", "207", "7.289", "0.946", "+5, +3", PhysicalStates.Solid, "544.55", "1837", "9.807", ElementTypes.PostTransitionMetal, 1753, ElementStructures.Bismuth);
        public static Element Polonium { get; } = new Element(84, "Po", "Polonium", 208.98243, "AB5C00", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p4"), "2", "197", "8.417", "1.9", "+4, +2", PhysicalStates.Solid, "527", "1235", "9.32", ElementTypes.Metalloid, 1898, ElementStructures.Polonium);
        public static Element Astatine { get; } = new Element(85, "At", "Astatine", 209.98715, "754F45", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p5"), "2.2", "202", "9.5", "2.8", "7, 5, 3, 1, -1", PhysicalStates.Solid, "575", "", "7", ElementTypes.Halogen, 1940, ElementStructures.Astatine);
        public static Element Radon { get; } = new Element(86, "Rn", "Radon", 222.01758, "428296", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6"), "", "220", "10.745", "", "0", PhysicalStates.Gas, "202", "211.45", "0.00973", ElementTypes.NobleGas, 1900, ElementStructures.Radon);
        public static Element Francium { get; } = new Element(87, "Fr", "Francium", 223.01973, "420066", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s1"), "0.7", "348", "3.9", "0.47", "+1", PhysicalStates.Solid, "300", "", "", ElementTypes.AlkaliMetal, 1939, ElementStructures.Francium);
        public static Element Radium { get; } = new Element(88, "Ra", "Radium", 226.02541, "007D00", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2"), "0.9", "283", "5.279", "", "+2", PhysicalStates.Solid, "973", "1413", "5", ElementTypes.AlkalineEarthMetal, 1898, ElementStructures.Radium);
        public static Element Actinium { get; } = new Element(89, "Ac", "Actinium", 227.02775, "70ABFA", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 6d1"), "1.1", "260", "5.17", "", "+3", PhysicalStates.Solid, "1324", "3471", "10.07", ElementTypes.Actinide, 1899, ElementStructures.Actinium);
        public static Element Thorium { get; } = new Element(90, "Th", "Thorium", 232.038, "00BAFF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 6d2"), "1.3", "237", "6.08", "", "+4", PhysicalStates.Solid, "2023", "5061", "11.72", ElementTypes.Actinide, 1828, ElementStructures.Thorium);
        public static Element Protactinium { get; } = new Element(91, "Pa", "Protactinium", 231.0359, "00A1FF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f2 6d1"), "1.5", "243", "5.89", "", "+5, +4", PhysicalStates.Solid, "1845", "", "15.37", ElementTypes.Actinide, 1913, ElementStructures.Protactinium);
        public static Element Uranium { get; } = new Element(92, "U", "Uranium", 238.0289, "008FFF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f3 6d1"), "1.38", "240", "6.194", "", "+6, +5, +4, +3", PhysicalStates.Solid, "1408", "4404", "18.95", ElementTypes.Actinide, 1789, ElementStructures.Uranium);
        public static Element Neptunium { get; } = new Element(93, "Np", "Neptunium", 237.04817, "0080FF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f4 6d1"), "1.36", "221", "6.266", "", "+6, +5, +4, +3", PhysicalStates.Solid, "917", "4175", "20.25", ElementTypes.Actinide, 1940, ElementStructures.Neptunium);
        public static Element Plutonium { get; } = new Element(94, "Pu", "Plutonium", 244.0642, "006BFF", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f6"), "1.28", "243", "6.06", "", "+6, +5, +4, +3", PhysicalStates.Solid, "913", "3501", "19.84", ElementTypes.Actinide, 1940, ElementStructures.Plutonium);
        public static Element Americium { get; } = new Element(95, "Am", "Americium", 243.06138, "545CF2", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f7"), "1.3", "244", "5.993", "", "+6, +5, +4, +3", PhysicalStates.Solid, "1449", "2284", "13.69", ElementTypes.Actinide, 1944, ElementStructures.Americium);
        public static Element Curium { get; } = new Element(96, "Cm", "Curium", 247.07035, "785CE3", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f7 6d1"), "1.3", "245", "6.02", "", "+3", PhysicalStates.Solid, "1618", "3400", "13.51", ElementTypes.Actinide, 1944, ElementStructures.Curium);
        public static Element Berkelium { get; } = new Element(97, "Bk", "Berkelium", 247.07031, "8A4FE3", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f9"), "1.3", "244", "6.23", "", "+4, +3", PhysicalStates.Solid, "1323", "", "14", ElementTypes.Actinide, 1949, ElementStructures.Berkelium);
        public static Element Californium { get; } = new Element(98, "Cf", "Californium", 251.07959, "A136D4", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f10"), "1.3", "245", "6.30", "", "+3", PhysicalStates.Solid, "1173", "", "", ElementTypes.Actinide, 1950, ElementStructures.Californium);
        public static Element Einsteinium { get; } = new Element(99, "Es", "Einsteinium", 252.083, "B31FD4", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f11"), "1.3", "245", "6.42", "", "+3", PhysicalStates.Solid, "1133", "", "", ElementTypes.Actinide, 1952, ElementStructures.Einsteinium);
        public static Element Fermium { get; } = new Element(100, "Fm", "Fermium", 257.09511, "B31FBA", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 5f12 7s2"), "1.3", "", "6.50", "", "+3", PhysicalStates.Solid, "1800", "", "", ElementTypes.Actinide, 1952, ElementStructures.Fermium);
        public static Element Mendelevium { get; } = new Element(101, "Md", "Mendelevium", 258.09843, "B30DA6", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f13"), "1.3", "", "6.58", "", "+3, +2", PhysicalStates.Solid, "1100", "", "", ElementTypes.Actinide, 1955, ElementStructures.Mendelevium);
        public static Element Nobelium { get; } = new Element(102, "No", "Nobelium", 259.101, "BD0D87", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14"), "1.3", "", "6.65", "", "+3, +2", PhysicalStates.Solid, "1100", "", "", ElementTypes.Actinide, 1957, ElementStructures.Nobelium);
        public static Element Lawrencium { get; } = new Element(103, "Lr", "Lawrencium", 262.11, "C70066", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d1"), "1.3", "", "", "", "+3", PhysicalStates.Solid, "1900", "", "", ElementTypes.Actinide, 1961, ElementStructures.Lawrencium);
        public static Element Rutherfordium { get; } = new Element(104, "Rf", "Rutherfordium", 267.122, "CC0059", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d2"), "", "", "", "", "+4", PhysicalStates.Solid, "", "", "", ElementTypes.TransitionMetal, 1964, ElementStructures.Rutherfordium);
        public static Element Dubnium { get; } = new Element(105, "Db", "Dubnium", 268.126, "D1004F", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d3"), "", "", "", "", "5, 4, 3", PhysicalStates.Solid, "", "", "", ElementTypes.TransitionMetal, 1967, ElementStructures.Dubnium);
        public static Element Seaborgium { get; } = new Element(106, "Sg", "Seaborgium", 271.134, "D90045", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d4"), "", "", "", "", "6, 5, 4, 3, 0", PhysicalStates.Solid, "", "", "", ElementTypes.TransitionMetal, 1974, ElementStructures.Seaborgium);
        public static Element Bohrium { get; } = new Element(107, "Bh", "Bohrium", 274.144, "E00038", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d5"), "", "", "", "", "7, 5, 4, 3", PhysicalStates.Solid, "", "", "", ElementTypes.TransitionMetal, 1976, ElementStructures.Bohrium);
        public static Element Hassium { get; } = new Element(108, "Hs", "Hassium", 277.152, "E6002E", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d6"), "", "", "", "", "8, 6, 5, 4, 3, 2", PhysicalStates.Solid, "", "", "", ElementTypes.TransitionMetal, 1984, ElementStructures.Hassium);
        public static Element Meitnerium { get; } = new Element(109, "Mt", "Meitnerium", 278.156, "EB0026", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d7"), "", "", "", "", "9, 8, 6, 4, 3, 1", PhysicalStates.Solid, "", "", "", ElementTypes.TransitionMetal, 1982, ElementStructures.Meitnerium);
        public static Element Darmstadtium { get; } = new Element(110, "Ds", "Darmstadtium", 281.165, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d8"), "", "", "", "", "8, 6, 4, 2, 0", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.TransitionMetal, 1994, ElementStructures.Darmstadtium);
        public static Element Roentgenium { get; } = new Element(111, "Rg", "Roentgenium", 282.169, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d9"), "", "", "", "", "5, 3, 1, -1", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.TransitionMetal, 1994, ElementStructures.Roentgenium);
        public static Element Copernicium { get; } = new Element(112, "Cn", "Copernicium", 285.177, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 5f14 6d10"), "", "", "", "", "2, 1, 0", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.TransitionMetal, 1996, ElementStructures.Copernicium);
        public static Element Nihonium { get; } = new Element(113, "Nh", "Nihonium", 286.183, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 5f14 6d10 7s2 7p1"), "", "", "", "", "", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.PostTransitionMetal, 2004, ElementStructures.Nihonium);
        public static Element Flerovium { get; } = new Element(114, "Fl", "Flerovium", 289.191, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 7p2 5f14 6d10"), "", "", "", "", "6, 4,2, 1, 0", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.PostTransitionMetal, 1998, ElementStructures.Flerovium);
        public static Element Moscovium { get; } = new Element(115, "Mc", "Moscovium", 290.196, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 7p3 5f14 6d10"), "", "", "", "", "3, 1", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.PostTransitionMetal, 2003, ElementStructures.Moscovium);
        public static Element Livermorium { get; } = new Element(116, "Lv", "Livermorium", 293.205, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 7p4 5f14 6d10"), "", "", "", "", "+4, +2, -2", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.PostTransitionMetal, 2000, ElementStructures.Livermorium);
        public static Element Tennessine { get; } = new Element(117, "Ts", "Tennessine", 294.211, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 7p5 5f14 6d10"), "", "", "", "", "+5, +3, +1, -1", PhysicalStates.ExpectedToBeASolid, "", "", "", ElementTypes.Halogen, 2010, ElementStructures.Tennessine);
        public static Element Oganesson { get; } = new Element(118, "Og", "Oganesson", 294.214, "", new ElectronConfiguration("1s2 2s2 2p6 3s2 3p6 4s2 3d10 4p6 5s2 4d10 5p6 6s2 4f14 5d10 6p6 7s2 7p6 5f14 6d10"), "", "", "", "", "+6, +4, +2, +1, 0, -1", PhysicalStates.ExpectedToBeAGas, "", "", "", ElementTypes.NobleGas, 2006, ElementStructures.Oganesson);
    }
}