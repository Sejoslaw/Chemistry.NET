/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System;
using System.Linq;
using Chemistry.NET.Elements.Models;
using Chemistry.NET.Hydrocarbons;

namespace Chemistry.NET.Compounds.Models
{
    public partial class ChemicalCompound : IHydrocarbon
    {
        /// <summary>
        /// Represents a max number of rings to check,
        /// when determining if the current compound is a Cycloalkane (0...this);
        /// </summary>
        public int CycloalkaneMaxNumberRingsCheck { get; set; } = 1_000_000;
        
        public bool IsHydrocarbon => IsOrganic && GetAtoms().FirstOrDefault(e =>
            e.Element != CommonElements.Hydrogen || e.Element != CommonElements.Carbon) == null;

        public bool IsAlkane => IsValidHydrocarbon((carbonCount, hydrogenCount) => hydrogenCount == 2 * carbonCount + 2); // C n H 2n + 2
        public bool IsAlkene => IsValidHydrocarbon((carbonCount, hydrogenCount) => hydrogenCount == 2 * carbonCount); // C n H 2n
        public bool IsAlkyne => IsValidHydrocarbon((carbonCount, hydrogenCount) => hydrogenCount == 2 * carbonCount - 2); // C n H 2n - 2
        public bool IsCycloalkane => IsValidHydrocarbon((carbonCount, hydrogenCount) =>
        {
            for (var i = 0; i < CycloalkaneMaxNumberRingsCheck; ++i)
            {
                if (IsValidCycloalkane(carbonCount, hydrogenCount, i))
                {
                    return true;
                }
            }

            return false;
        }); // C n H 2(n+1-r)  =>  n - number of carbons; r - number of rings

        // TODO: Implement it. Currently the library does not count number of bonds.
        public bool IsAlkadiene => throw new NotImplementedException("[W.I.P.] Not implemented until the library supports counting the number of bonds."); // Contains 2 double bonds among carbon atoms

        public bool IsSaturated => IsAlkane || IsCycloalkane; // TODO: Add check for IsAlkadiene when we will support counting number of bonds 
        public bool IsUnsaturated => IsAlkene || IsAlkyne;

        public bool IsValidHydrocarbon(Func<int, int, bool> func)
        {
            var atoms = GetAtoms();
            var carbonCount = atoms.First(e => e.Element == CommonElements.Carbon).Count;
            var hydrogenCount = atoms.First(e => e.Element == CommonElements.Hydrogen).Count;

            return func(carbonCount, hydrogenCount);
        }
        
        public static bool IsValidCycloalkane(int carbonCount, int hydrogenCount, int numberOfRings)
        {
            return hydrogenCount == 2 * (carbonCount + 1 - numberOfRings);
        }
    }
}
