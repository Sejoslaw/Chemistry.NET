/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Linq;
using Chemistry.NET.Molecules;

namespace Chemistry.NET.Compounds.Models
{
    public partial class ChemicalCompound : IMolecule
    {
        public bool IsHomonuclear => this.GetAtoms().Count() == 1;
        public bool IsHeteronuclear => this.GetAtoms().Count() > 1;
        public bool IsDiatomic
        {
            get
            {
                var atoms = this.GetAtoms();
                return (atoms.Count() == 1 && atoms.ElementAt(0).Count == 2) || 
                        (atoms.Count() == 2 && atoms.ElementAt(0).Count == 1 && atoms.ElementAt(1).Count == 1);
            }
        }

        public bool AreIsomers(IMolecule molecule)
        {
            if (!(molecule is ChemicalCompound))
            {
                return false;
            }

            var compound = molecule as ChemicalCompound;
            return AreAtomsCountEqual(compound);
        }
    }
}
