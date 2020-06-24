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
using Chemistry.NET.Graphs.Models;
using Chemistry.NET.Ions.Models;
using Chemistry.NET.Particles.Models;

namespace Chemistry.NET.Common
{
    public static class Container
    {
        // --== Properties ==--
        
        public static IList<Particle> Particles { get; } = GetAll<Particle>(typeof(CommonParticles));
        public static IList<ElectronShell> ElectronShells { get; } = GetAll<ElectronShell>(typeof(ElectronShells));
        public static IList<Element> Elements { get; } = GetAll<Element>(typeof(CommonElements));
        public static IList<ElementType> ElementTypes { get; } = GetAll<ElementType>(typeof(ElementTypes));
        public static IList<PeriodicTableElement> PeriodicTableElements { get; } = GetAll<PeriodicTableElement>(typeof(PeriodicTable));
        public static IList<PeriodicTableGroup> PeriodicTableGroups { get; } = GetAll<PeriodicTableGroup>(typeof(PeriodicTableGroups));
        public static IList<PhysicalState> PhysicalStates { get; } = GetAll<PhysicalState>(typeof(PhysicalStates));
        public static IList<ElementStructure> ElementStructures { get; } = GetAll<ElementStructure>(typeof(ElementStructures));
        public static IList<Isotope> Isotopes { get; } = GetAll<Isotope>(typeof(CommonIsotopes)); 
        public static IList<ChemicalCompound> CommonCompounds { get; } = GetAll<ChemicalCompound>(typeof(CommonCompounds));
        public static IList<Ion> Ions { get; } = GetAll<Ion>(typeof(CommonIons));
        public static IList<MolecularShape> MolecularShapes { get; } = GetAll<MolecularShape>(typeof(MolecularShapes));
        public static IList<BondAngle> BondAngles { get; } = GetAll<BondAngle>(typeof(BondAngles));

        public static IList<Isotope> MonoisotopicElements { get; } = new List<Isotope>
        {
            CommonIsotopes.Be9, CommonIsotopes.F19, CommonIsotopes.Na23, CommonIsotopes.Al27, CommonIsotopes.P31, 
            CommonIsotopes.Sc45, CommonIsotopes.V51, CommonIsotopes.Mn55, CommonIsotopes.Co59, CommonIsotopes.As75, 
            CommonIsotopes.Rb85, CommonIsotopes.Y89, CommonIsotopes.Nb93, CommonIsotopes.Rh103, CommonIsotopes.In113,
            CommonIsotopes.I127, CommonIsotopes.Cs133, CommonIsotopes.La139, CommonIsotopes.Pr141, CommonIsotopes.Eu153, 
            CommonIsotopes.Tb159, CommonIsotopes.Ho165, CommonIsotopes.Tm169, CommonIsotopes.Lu175, CommonIsotopes.Re185, 
            CommonIsotopes.Au197
        };

        public static IList<Isotope> MononuclidicElements { get; } = new List<Isotope>
        {
            CommonIsotopes.Be9, CommonIsotopes.F19, CommonIsotopes.Na23, CommonIsotopes.Al27, CommonIsotopes.P31,
            CommonIsotopes.Sc45, CommonIsotopes.Mn55, CommonIsotopes.Co59, CommonIsotopes.As75, CommonIsotopes.Y89,
            CommonIsotopes.Nb93, CommonIsotopes.Rh103, CommonIsotopes.I127, CommonIsotopes.Cs133, CommonIsotopes.Pr141,
            CommonIsotopes.Tb159, CommonIsotopes.Ho165, CommonIsotopes.Tm169, CommonIsotopes.Au197, CommonIsotopes.Bi209,
            CommonIsotopes.Pa231
        };

        public static IList<Isotope> AlphaNuclides { get; } = new List<Isotope>
        {
            CommonIsotopes.He4, CommonIsotopes.Be8, CommonIsotopes.C12, CommonIsotopes.O16, CommonIsotopes.Ne20,
            CommonIsotopes.Mg24, CommonIsotopes.Si28, CommonIsotopes.S32, CommonIsotopes.Ar36, CommonIsotopes.Ca40, 
            CommonIsotopes.Ti44, CommonIsotopes.Cr48, CommonIsotopes.Fe52, CommonIsotopes.Ni56, CommonIsotopes.Zn60
        };

        public static IList<Isotope> PrimordialNuclides { get; } = new List<Isotope>
        {
            CommonIsotopes.Te128, CommonIsotopes.Xe124, CommonIsotopes.Kr78, CommonIsotopes.Xe136, CommonIsotopes.Ge76,
            CommonIsotopes.Ba130, CommonIsotopes.Se82, CommonIsotopes.Cd116, CommonIsotopes.Ca48, CommonIsotopes.Zr96,
            CommonIsotopes.Bi209, CommonIsotopes.Te130, CommonIsotopes.Nd150, CommonIsotopes.Mo100, CommonIsotopes.Eu151,
            CommonIsotopes.W180, CommonIsotopes.V50, CommonIsotopes.Cd113, CommonIsotopes.Sm148, CommonIsotopes.Nd144,
            CommonIsotopes.Os186, CommonIsotopes.Hf174, CommonIsotopes.In115, CommonIsotopes.Gd152, CommonIsotopes.Pt190,
            CommonIsotopes.Sm147, CommonIsotopes.La138, CommonIsotopes.Rb87, CommonIsotopes.Re187, CommonIsotopes.Lu176,
            CommonIsotopes.Th232, CommonIsotopes.U238, CommonIsotopes.K40, CommonIsotopes.U235
        };
        
        // --== Methods ==--

        private static IList<TModel> GetAll<TModel>(Type type)
        {
            return type.GetProperties().Select(obj => (TModel) obj.GetValue(null)).ToList();
        }
    }
}
