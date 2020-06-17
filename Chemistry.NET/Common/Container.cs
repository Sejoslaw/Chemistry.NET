/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using System.Linq;
using Chemistry.NET.Compounds.Models;
using Chemistry.NET.Elements.Models;
using Chemistry.NET.Particles.Models;

namespace Chemistry.NET.Common
{
    public static class Container
    {
        public static IList<Particle> Particles { get; } = GetAll<Particle>(typeof(Particles.Models.Particles));
        public static IList<ElectronShell> ElectronShells { get; } = GetAll<ElectronShell>(typeof(ElectronShells));
        public static IList<Element> Elements { get; } = GetAll<Element>(typeof(Elements.Models.Elements));
        public static IList<ElementType> ElementTypes { get; } = GetAll<ElementType>(typeof(ElementTypes));
        public static IList<PeriodicTableElement> PeriodicTableElements { get; } = GetAll<PeriodicTableElement>(typeof(PeriodicTable));
        public static IList<PeriodicTableGroup> PeriodicTableGroups { get; } = GetAll<PeriodicTableGroup>(typeof(PeriodicTableGroups));
        public static IList<PhysicalState> PhysicalStates { get; } = GetAll<PhysicalState>(typeof(PhysicalStates));
        public static IList<ElementStructure> ElementStructures { get; } = GetAll<ElementStructure>(typeof(ElementStructures));
        public static IList<Isotope> Isotopes { get; } = GetAll<Isotope>(typeof(Isotopes)); 
        public static IList<ChemicalCompound> CommonCompounds { get; } = GetAll<ChemicalCompound>(typeof(CommonCompounds));

        private static IList<TModel> GetAll<TModel>(Type type)
        {
            return type.GetProperties().Select(obj => (TModel) obj.GetValue(null)).ToList();
        }
    }
}
