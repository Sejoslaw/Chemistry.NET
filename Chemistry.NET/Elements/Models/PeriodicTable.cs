/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Elements.Models
{
    public static class PeriodicTable
    {
        // Actinides

        public static PeriodicTableElement Actinium { get; } = new PeriodicTableElement(Elements.Actinium, 1, 1, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Thorium { get; } = new PeriodicTableElement(Elements.Thorium, 1, 2, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Protactinium { get; } = new PeriodicTableElement(Elements.Protactinium, 1, 3, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Uranium { get; } = new PeriodicTableElement(Elements.Uranium, 1, 4, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Neptunium { get; } = new PeriodicTableElement(Elements.Neptunium, 1, 5, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Plutonium { get; } = new PeriodicTableElement(Elements.Plutonium, 1, 6, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Americium { get; } = new PeriodicTableElement(Elements.Americium, 1, 7, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Curium { get; } = new PeriodicTableElement(Elements.Curium, 1, 8, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Berkelium { get; } = new PeriodicTableElement(Elements.Berkelium, 1, 9, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Californium { get; } = new PeriodicTableElement(Elements.Californium, 1, 10, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Einsteinium { get; } = new PeriodicTableElement(Elements.Einsteinium, 1, 11, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Fermium { get; } = new PeriodicTableElement(Elements.Fermium, 1, 12, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Mendelevium { get; } = new PeriodicTableElement(Elements.Mendelevium, 1, 13, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Nobelium { get; } = new PeriodicTableElement(Elements.Nobelium, 1, 14, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Lawrencium { get; } = new PeriodicTableElement(Elements.Lawrencium, 1, 15, PeriodicTableGroups.Actinide);

        // Lanthanides

        public static PeriodicTableElement Lanthanum { get; } = new PeriodicTableElement(Elements.Lanthanum, 1, 1, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Cerium { get; } = new PeriodicTableElement(Elements.Cerium, 1, 2, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Praseodymium { get; } = new PeriodicTableElement(Elements.Praseodymium, 1, 3, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Neodymium { get; } = new PeriodicTableElement(Elements.Neodymium, 1, 4, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Promethium { get; } = new PeriodicTableElement(Elements.Promethium, 1, 5, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Samarium { get; } = new PeriodicTableElement(Elements.Samarium, 1, 6, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Europium { get; } = new PeriodicTableElement(Elements.Europium, 1, 7, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Gadolinium { get; } = new PeriodicTableElement(Elements.Gadolinium, 1, 8, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Terbium { get; } = new PeriodicTableElement(Elements.Terbium, 1, 9, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Dysprosium { get; } = new PeriodicTableElement(Elements.Dysprosium, 1, 10, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Holmium { get; } = new PeriodicTableElement(Elements.Holmium, 1, 11, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Erbium { get; } = new PeriodicTableElement(Elements.Erbium, 1, 12, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Thulium { get; } = new PeriodicTableElement(Elements.Thulium, 1, 13, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Ytterbium { get; } = new PeriodicTableElement(Elements.Ytterbium, 1, 14, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Lutetium { get; } = new PeriodicTableElement(Elements.Lutetium, 1, 15, PeriodicTableGroups.Lanthanide);

        // Main

        public static PeriodicTableElement Hydrogen { get; } = new PeriodicTableElement(Elements.Hydrogen, 1, 1, PeriodicTableGroups.Main);
        public static PeriodicTableElement Lithium { get; } = new PeriodicTableElement(Elements.Lithium, 1, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Sodium { get; } = new PeriodicTableElement(Elements.Sodium, 1, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Potassium { get; } = new PeriodicTableElement(Elements.Potassium, 1, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rubidium { get; } = new PeriodicTableElement(Elements.Rubidium, 1, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Cesium { get; } = new PeriodicTableElement(Elements.Cesium, 1, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Francium { get; } = new PeriodicTableElement(Elements.Francium, 1, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Beryllium { get; } = new PeriodicTableElement(Elements.Beryllium, 2, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Magnesium { get; } = new PeriodicTableElement(Elements.Magnesium, 2, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Calcium { get; } = new PeriodicTableElement(Elements.Calcium, 2, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Strontium { get; } = new PeriodicTableElement(Elements.Strontium, 2, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Barium { get; } = new PeriodicTableElement(Elements.Barium, 2, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Radium { get; } = new PeriodicTableElement(Elements.Radium, 2, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Scandium { get; } = new PeriodicTableElement(Elements.Scandium, 3, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Yttrium { get; } = new PeriodicTableElement(Elements.Yttrium, 3, 5, PeriodicTableGroups.Main);
        
        public static PeriodicTableElement Titanium { get; } = new PeriodicTableElement(Elements.Titanium, 4, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Zirconium { get; } = new PeriodicTableElement(Elements.Zirconium, 4, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Hafnium { get; } = new PeriodicTableElement(Elements.Hafnium, 4, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rutherfordium { get; } = new PeriodicTableElement(Elements.Rutherfordium, 4, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Vanadium { get; } = new PeriodicTableElement(Elements.Vanadium, 5, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Niobium { get; } = new PeriodicTableElement(Elements.Niobium, 5, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tantalum { get; } = new PeriodicTableElement(Elements.Tantalum, 5, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Dubnium { get; } = new PeriodicTableElement(Elements.Dubnium, 5, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Chromium { get; } = new PeriodicTableElement(Elements.Chromium, 6, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Molybdenum { get; } = new PeriodicTableElement(Elements.Molybdenum, 6, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tungsten { get; } = new PeriodicTableElement(Elements.Tungsten, 6, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Seaborgium { get; } = new PeriodicTableElement(Elements.Seaborgium, 6, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Manganese { get; } = new PeriodicTableElement(Elements.Manganese, 7, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Technetium { get; } = new PeriodicTableElement(Elements.Technetium, 7, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rhenium { get; } = new PeriodicTableElement(Elements.Rhenium, 7, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Bohrium { get; } = new PeriodicTableElement(Elements.Bohrium, 7, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Iron { get; } = new PeriodicTableElement(Elements.Iron, 8, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Ruthenium { get; } = new PeriodicTableElement(Elements.Ruthenium, 8, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Osmium { get; } = new PeriodicTableElement(Elements.Osmium, 8, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Hassium { get; } = new PeriodicTableElement(Elements.Hassium, 8, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Cobalt { get; } = new PeriodicTableElement(Elements.Cobalt, 9, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rhodium { get; } = new PeriodicTableElement(Elements.Rhodium, 9, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Iridium { get; } = new PeriodicTableElement(Elements.Iridium, 9, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Meitnerium { get; } = new PeriodicTableElement(Elements.Meitnerium, 9, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Nickel { get; } = new PeriodicTableElement(Elements.Nickel, 10, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Palladium { get; } = new PeriodicTableElement(Elements.Palladium, 10, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Platinum { get; } = new PeriodicTableElement(Elements.Platinum, 10, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Darmstadtium { get; } = new PeriodicTableElement(Elements.Darmstadtium, 10, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Copper { get; } = new PeriodicTableElement(Elements.Copper, 11, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Silver { get; } = new PeriodicTableElement(Elements.Silver, 11, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Gold { get; } = new PeriodicTableElement(Elements.Gold, 11, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Roentgenium { get; } = new PeriodicTableElement(Elements.Roentgenium, 11, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Zinc { get; } = new PeriodicTableElement(Elements.Zinc, 12, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Cadmium { get; } = new PeriodicTableElement(Elements.Cadmium, 12, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Mercury { get; } = new PeriodicTableElement(Elements.Mercury, 12, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Copernicium { get; } = new PeriodicTableElement(Elements.Copernicium, 12, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Boron { get; } = new PeriodicTableElement(Elements.Boron, 13, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Aluminum { get; } = new PeriodicTableElement(Elements.Aluminum, 13, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Gallium { get; } = new PeriodicTableElement(Elements.Gallium, 13, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Indium { get; } = new PeriodicTableElement(Elements.Indium, 13, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Thallium { get; } = new PeriodicTableElement(Elements.Thallium, 13, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Nihonium { get; } = new PeriodicTableElement(Elements.Nihonium, 13, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Carbon { get; } = new PeriodicTableElement(Elements.Carbon, 14, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Silicon { get; } = new PeriodicTableElement(Elements.Silicon, 14, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Germanium { get; } = new PeriodicTableElement(Elements.Germanium, 14, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tin { get; } = new PeriodicTableElement(Elements.Tin, 14, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Lead { get; } = new PeriodicTableElement(Elements.Lead, 14, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Flerovium { get; } = new PeriodicTableElement(Elements.Flerovium, 14, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Nitrogen { get; } = new PeriodicTableElement(Elements.Nitrogen, 15, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Phosphorus { get; } = new PeriodicTableElement(Elements.Phosphorus, 15, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Arsenic { get; } = new PeriodicTableElement(Elements.Arsenic, 15, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Antimony { get; } = new PeriodicTableElement(Elements.Antimony, 15, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Bismuth { get; } = new PeriodicTableElement(Elements.Bismuth, 15, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Moscovium { get; } = new PeriodicTableElement(Elements.Moscovium, 15, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Oxygen { get; } = new PeriodicTableElement(Elements.Oxygen, 16, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Sulfur { get; } = new PeriodicTableElement(Elements.Sulfur, 16, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Selenium { get; } = new PeriodicTableElement(Elements.Selenium, 16, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tellurium { get; } = new PeriodicTableElement(Elements.Tellurium, 16, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Polonium { get; } = new PeriodicTableElement(Elements.Polonium, 16, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Livermorium { get; } = new PeriodicTableElement(Elements.Livermorium, 16, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Fluorine { get; } = new PeriodicTableElement(Elements.Fluorine, 17, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Chlorine { get; } = new PeriodicTableElement(Elements.Chlorine, 17, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Bromine { get; } = new PeriodicTableElement(Elements.Bromine, 17, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Iodine { get; } = new PeriodicTableElement(Elements.Iodine, 17, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Astatine { get; } = new PeriodicTableElement(Elements.Astatine, 17, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tennessine { get; } = new PeriodicTableElement(Elements.Tennessine, 17, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Helium { get; } = new PeriodicTableElement(Elements.Helium, 18, 1, PeriodicTableGroups.Main);
        public static PeriodicTableElement Neon { get; } = new PeriodicTableElement(Elements.Neon, 18, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Argon { get; } = new PeriodicTableElement(Elements.Argon, 18, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Krypton { get; } = new PeriodicTableElement(Elements.Krypton, 18, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Xenon { get; } = new PeriodicTableElement(Elements.Xenon, 18, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Radon { get; } = new PeriodicTableElement(Elements.Radon, 18, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Oganesson { get; } = new PeriodicTableElement(Elements.Oganesson, 18, 7, PeriodicTableGroups.Main);
    }
}
