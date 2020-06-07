/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Collections.Generic;
using Chemistry.NET.Models.Particles;

namespace Chemistry.NET.Models
{
    public static class Container
    {
        public static IEnumerable<Particle> Particles { get; } = GetAll<Particle>(typeof(Particles.Particles));
        public static IEnumerable<ElectronShell> ElectronShells { get; } = GetAll<ElectronShell>(typeof(ElectronShells));
        public static IEnumerable<Element> Elements { get; } = GetAll<Element>(typeof(Elements));
        public static IEnumerable<ElementType> ElementTypes { get; } = GetAll<ElementType>(typeof(ElementTypes));
        public static IEnumerable<PeriodicTableElement> PeriodicTableElements { get; } = GetAll<PeriodicTableElement>(typeof(PeriodicTable));
        public static IEnumerable<PeriodicTableGroup> PeriodicTableGroups { get; } = GetAll<PeriodicTableGroup>(typeof(PeriodicTableGroups));
        public static IEnumerable<PhysicalState> PhysicalStates { get; } = GetAll<PhysicalState>(typeof(PhysicalStates));
        public static IEnumerable<ElementStructure> ElementStructures { get; } = GetAll<ElementStructure>(typeof(ElementStructures));

        private static IEnumerable<TModel> GetAll<TModel>(Type type)
        {
            ICollection<TModel> list = new List<TModel>();

            foreach (var obj in type.GetProperties())
            {
                list.Add((TModel)obj.GetValue(null));
            }

            list = (list as List<TModel>).AsReadOnly();

            return list;
        }
    }
}
