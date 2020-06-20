/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Molecules
{
    /// <summary>
    /// Describes an object to be a Molecule.
    /// </summary>
    public interface IMolecule
    {
        /// <summary>
        /// Homonuclear molecules are molecules composed of only one type of element. 
        /// Homonuclear molecules may consist of various numbers of atoms, depending on the element's properties. 
        /// </summary>
        /// <value></value>
        bool IsHomonuclear { get; }
        /// <summary>
        /// A heteronuclear molecule is a molecule composed of atoms of more than one chemical element.
        /// </summary>
        /// <value></value>
        bool IsHeteronuclear { get; }
        /// <summary>
        /// Diatomic molecules are molecules composed of only two atoms, of the same or different chemical elements. 
        /// </summary>
        /// <value></value>
        bool IsDiatomic { get; }
    }
}
