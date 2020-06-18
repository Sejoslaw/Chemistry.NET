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

        public static PeriodicTableElement Actinium { get; } = new PeriodicTableElement(CommonElements.Actinium, 1, 1, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Thorium { get; } = new PeriodicTableElement(CommonElements.Thorium, 1, 2, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Protactinium { get; } = new PeriodicTableElement(CommonElements.Protactinium, 1, 3, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Uranium { get; } = new PeriodicTableElement(CommonElements.Uranium, 1, 4, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Neptunium { get; } = new PeriodicTableElement(CommonElements.Neptunium, 1, 5, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Plutonium { get; } = new PeriodicTableElement(CommonElements.Plutonium, 1, 6, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Americium { get; } = new PeriodicTableElement(CommonElements.Americium, 1, 7, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Curium { get; } = new PeriodicTableElement(CommonElements.Curium, 1, 8, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Berkelium { get; } = new PeriodicTableElement(CommonElements.Berkelium, 1, 9, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Californium { get; } = new PeriodicTableElement(CommonElements.Californium, 1, 10, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Einsteinium { get; } = new PeriodicTableElement(CommonElements.Einsteinium, 1, 11, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Fermium { get; } = new PeriodicTableElement(CommonElements.Fermium, 1, 12, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Mendelevium { get; } = new PeriodicTableElement(CommonElements.Mendelevium, 1, 13, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Nobelium { get; } = new PeriodicTableElement(CommonElements.Nobelium, 1, 14, PeriodicTableGroups.Actinide);
        public static PeriodicTableElement Lawrencium { get; } = new PeriodicTableElement(CommonElements.Lawrencium, 1, 15, PeriodicTableGroups.Actinide);

        // Lanthanides

        public static PeriodicTableElement Lanthanum { get; } = new PeriodicTableElement(CommonElements.Lanthanum, 1, 1, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Cerium { get; } = new PeriodicTableElement(CommonElements.Cerium, 1, 2, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Praseodymium { get; } = new PeriodicTableElement(CommonElements.Praseodymium, 1, 3, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Neodymium { get; } = new PeriodicTableElement(CommonElements.Neodymium, 1, 4, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Promethium { get; } = new PeriodicTableElement(CommonElements.Promethium, 1, 5, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Samarium { get; } = new PeriodicTableElement(CommonElements.Samarium, 1, 6, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Europium { get; } = new PeriodicTableElement(CommonElements.Europium, 1, 7, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Gadolinium { get; } = new PeriodicTableElement(CommonElements.Gadolinium, 1, 8, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Terbium { get; } = new PeriodicTableElement(CommonElements.Terbium, 1, 9, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Dysprosium { get; } = new PeriodicTableElement(CommonElements.Dysprosium, 1, 10, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Holmium { get; } = new PeriodicTableElement(CommonElements.Holmium, 1, 11, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Erbium { get; } = new PeriodicTableElement(CommonElements.Erbium, 1, 12, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Thulium { get; } = new PeriodicTableElement(CommonElements.Thulium, 1, 13, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Ytterbium { get; } = new PeriodicTableElement(CommonElements.Ytterbium, 1, 14, PeriodicTableGroups.Lanthanide);
        public static PeriodicTableElement Lutetium { get; } = new PeriodicTableElement(CommonElements.Lutetium, 1, 15, PeriodicTableGroups.Lanthanide);

        // Main

        public static PeriodicTableElement Hydrogen { get; } = new PeriodicTableElement(CommonElements.Hydrogen, 1, 1, PeriodicTableGroups.Main);
        public static PeriodicTableElement Lithium { get; } = new PeriodicTableElement(CommonElements.Lithium, 1, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Sodium { get; } = new PeriodicTableElement(CommonElements.Sodium, 1, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Potassium { get; } = new PeriodicTableElement(CommonElements.Potassium, 1, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rubidium { get; } = new PeriodicTableElement(CommonElements.Rubidium, 1, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Cesium { get; } = new PeriodicTableElement(CommonElements.Cesium, 1, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Francium { get; } = new PeriodicTableElement(CommonElements.Francium, 1, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Beryllium { get; } = new PeriodicTableElement(CommonElements.Beryllium, 2, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Magnesium { get; } = new PeriodicTableElement(CommonElements.Magnesium, 2, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Calcium { get; } = new PeriodicTableElement(CommonElements.Calcium, 2, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Strontium { get; } = new PeriodicTableElement(CommonElements.Strontium, 2, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Barium { get; } = new PeriodicTableElement(CommonElements.Barium, 2, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Radium { get; } = new PeriodicTableElement(CommonElements.Radium, 2, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Scandium { get; } = new PeriodicTableElement(CommonElements.Scandium, 3, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Yttrium { get; } = new PeriodicTableElement(CommonElements.Yttrium, 3, 5, PeriodicTableGroups.Main);
        
        public static PeriodicTableElement Titanium { get; } = new PeriodicTableElement(CommonElements.Titanium, 4, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Zirconium { get; } = new PeriodicTableElement(CommonElements.Zirconium, 4, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Hafnium { get; } = new PeriodicTableElement(CommonElements.Hafnium, 4, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rutherfordium { get; } = new PeriodicTableElement(CommonElements.Rutherfordium, 4, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Vanadium { get; } = new PeriodicTableElement(CommonElements.Vanadium, 5, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Niobium { get; } = new PeriodicTableElement(CommonElements.Niobium, 5, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tantalum { get; } = new PeriodicTableElement(CommonElements.Tantalum, 5, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Dubnium { get; } = new PeriodicTableElement(CommonElements.Dubnium, 5, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Chromium { get; } = new PeriodicTableElement(CommonElements.Chromium, 6, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Molybdenum { get; } = new PeriodicTableElement(CommonElements.Molybdenum, 6, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tungsten { get; } = new PeriodicTableElement(CommonElements.Tungsten, 6, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Seaborgium { get; } = new PeriodicTableElement(CommonElements.Seaborgium, 6, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Manganese { get; } = new PeriodicTableElement(CommonElements.Manganese, 7, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Technetium { get; } = new PeriodicTableElement(CommonElements.Technetium, 7, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rhenium { get; } = new PeriodicTableElement(CommonElements.Rhenium, 7, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Bohrium { get; } = new PeriodicTableElement(CommonElements.Bohrium, 7, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Iron { get; } = new PeriodicTableElement(CommonElements.Iron, 8, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Ruthenium { get; } = new PeriodicTableElement(CommonElements.Ruthenium, 8, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Osmium { get; } = new PeriodicTableElement(CommonElements.Osmium, 8, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Hassium { get; } = new PeriodicTableElement(CommonElements.Hassium, 8, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Cobalt { get; } = new PeriodicTableElement(CommonElements.Cobalt, 9, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Rhodium { get; } = new PeriodicTableElement(CommonElements.Rhodium, 9, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Iridium { get; } = new PeriodicTableElement(CommonElements.Iridium, 9, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Meitnerium { get; } = new PeriodicTableElement(CommonElements.Meitnerium, 9, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Nickel { get; } = new PeriodicTableElement(CommonElements.Nickel, 10, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Palladium { get; } = new PeriodicTableElement(CommonElements.Palladium, 10, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Platinum { get; } = new PeriodicTableElement(CommonElements.Platinum, 10, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Darmstadtium { get; } = new PeriodicTableElement(CommonElements.Darmstadtium, 10, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Copper { get; } = new PeriodicTableElement(CommonElements.Copper, 11, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Silver { get; } = new PeriodicTableElement(CommonElements.Silver, 11, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Gold { get; } = new PeriodicTableElement(CommonElements.Gold, 11, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Roentgenium { get; } = new PeriodicTableElement(CommonElements.Roentgenium, 11, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Zinc { get; } = new PeriodicTableElement(CommonElements.Zinc, 12, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Cadmium { get; } = new PeriodicTableElement(CommonElements.Cadmium, 12, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Mercury { get; } = new PeriodicTableElement(CommonElements.Mercury, 12, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Copernicium { get; } = new PeriodicTableElement(CommonElements.Copernicium, 12, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Boron { get; } = new PeriodicTableElement(CommonElements.Boron, 13, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Aluminum { get; } = new PeriodicTableElement(CommonElements.Aluminum, 13, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Gallium { get; } = new PeriodicTableElement(CommonElements.Gallium, 13, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Indium { get; } = new PeriodicTableElement(CommonElements.Indium, 13, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Thallium { get; } = new PeriodicTableElement(CommonElements.Thallium, 13, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Nihonium { get; } = new PeriodicTableElement(CommonElements.Nihonium, 13, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Carbon { get; } = new PeriodicTableElement(CommonElements.Carbon, 14, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Silicon { get; } = new PeriodicTableElement(CommonElements.Silicon, 14, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Germanium { get; } = new PeriodicTableElement(CommonElements.Germanium, 14, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tin { get; } = new PeriodicTableElement(CommonElements.Tin, 14, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Lead { get; } = new PeriodicTableElement(CommonElements.Lead, 14, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Flerovium { get; } = new PeriodicTableElement(CommonElements.Flerovium, 14, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Nitrogen { get; } = new PeriodicTableElement(CommonElements.Nitrogen, 15, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Phosphorus { get; } = new PeriodicTableElement(CommonElements.Phosphorus, 15, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Arsenic { get; } = new PeriodicTableElement(CommonElements.Arsenic, 15, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Antimony { get; } = new PeriodicTableElement(CommonElements.Antimony, 15, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Bismuth { get; } = new PeriodicTableElement(CommonElements.Bismuth, 15, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Moscovium { get; } = new PeriodicTableElement(CommonElements.Moscovium, 15, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Oxygen { get; } = new PeriodicTableElement(CommonElements.Oxygen, 16, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Sulfur { get; } = new PeriodicTableElement(CommonElements.Sulfur, 16, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Selenium { get; } = new PeriodicTableElement(CommonElements.Selenium, 16, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tellurium { get; } = new PeriodicTableElement(CommonElements.Tellurium, 16, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Polonium { get; } = new PeriodicTableElement(CommonElements.Polonium, 16, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Livermorium { get; } = new PeriodicTableElement(CommonElements.Livermorium, 16, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Fluorine { get; } = new PeriodicTableElement(CommonElements.Fluorine, 17, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Chlorine { get; } = new PeriodicTableElement(CommonElements.Chlorine, 17, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Bromine { get; } = new PeriodicTableElement(CommonElements.Bromine, 17, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Iodine { get; } = new PeriodicTableElement(CommonElements.Iodine, 17, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Astatine { get; } = new PeriodicTableElement(CommonElements.Astatine, 17, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Tennessine { get; } = new PeriodicTableElement(CommonElements.Tennessine, 17, 7, PeriodicTableGroups.Main);

        public static PeriodicTableElement Helium { get; } = new PeriodicTableElement(CommonElements.Helium, 18, 1, PeriodicTableGroups.Main);
        public static PeriodicTableElement Neon { get; } = new PeriodicTableElement(CommonElements.Neon, 18, 2, PeriodicTableGroups.Main);
        public static PeriodicTableElement Argon { get; } = new PeriodicTableElement(CommonElements.Argon, 18, 3, PeriodicTableGroups.Main);
        public static PeriodicTableElement Krypton { get; } = new PeriodicTableElement(CommonElements.Krypton, 18, 4, PeriodicTableGroups.Main);
        public static PeriodicTableElement Xenon { get; } = new PeriodicTableElement(CommonElements.Xenon, 18, 5, PeriodicTableGroups.Main);
        public static PeriodicTableElement Radon { get; } = new PeriodicTableElement(CommonElements.Radon, 18, 6, PeriodicTableGroups.Main);
        public static PeriodicTableElement Oganesson { get; } = new PeriodicTableElement(CommonElements.Oganesson, 18, 7, PeriodicTableGroups.Main);
    }
}
