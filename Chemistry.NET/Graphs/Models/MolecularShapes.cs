/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Graphs.Models
{
    /// <summary>
    /// Container for known Molecular Shapes.
    /// </summary>
    public static class MolecularShapes
    {
        public static MolecularShape Linear { get; } = new MolecularShape(2, new[] { 180.0 }, 0);
        public static MolecularShape TrigonalPlanar { get; } = new MolecularShape(3, new[] { 120.0 }, 0);
        public static MolecularShape Angular { get; } = new MolecularShape(2, new[] { 90.0, 120.0 }, 1);
        public static MolecularShape Tetrahedral { get; } = new MolecularShape(4, new[] { 109.5 }, 0);
        public static MolecularShape TrigonalPyramidal { get; } = new MolecularShape(3, new[] { 90.0, 109.5 }, 1);
        public static MolecularShape Bent { get; } = new MolecularShape(2, new[] { 90.0, 120.0 }, 1);
        public static MolecularShape TrigonalBipyramidal { get; } = new MolecularShape(5, new[] { 90.0, 120.0 }, 0);
        public static MolecularShape Seesaw { get; } = new MolecularShape(4, new[] { 180.0, 120.0, 90.0, 173.1, 101.6 }, 1);
        public static MolecularShape TShaped { get; } = new MolecularShape(3, new[] { 90.0, 180.0 }, 1);
        public static MolecularShape Octahedral { get; } = new MolecularShape(6, new[] { 90.0 }, 0);
        public static MolecularShape SquarePyramidal { get; } = new MolecularShape(5, new[] { 90.0 }, 0);
        public static MolecularShape SquarePlanar { get; } = new MolecularShape(4, new[] { 90.0 }, 0);
        public static MolecularShape PentagonalBipyramidal { get; } = new MolecularShape(7, new[] { 90.0, 72.0 }, 0);
        public static MolecularShape PentagonalPyramidal { get; } = new MolecularShape(6, new[] { 90.0, 72.0 }, 1);
        public static MolecularShape PentagonalPlanar { get; } = new MolecularShape(5, new[] { 72.0 }, 0);
        public static MolecularShape SquareAntiprismatic { get; } = new MolecularShape(8, new[] { 45.0 }, 0);
        public static MolecularShape TricappedTrigonalPrismatic { get; } = new MolecularShape(9, new[] { 30.0 }, 0);
        public static MolecularShape TrigonalPrismatic { get; } = new MolecularShape(6, new[] { 60.0 }, 0);
    }
}
