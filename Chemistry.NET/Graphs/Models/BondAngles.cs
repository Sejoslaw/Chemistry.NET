/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Graphs.Models
{
    public static class BondAngles
    {
        public static BondAngle Linear { get; } = new BondAngle(2, 0, 2, MolecularShapes.Linear);
        public static BondAngle TrigonalPlanar { get; } = new BondAngle(3, 0, 3, MolecularShapes.TrigonalPlanar);
        public static BondAngle Angular { get; } = new BondAngle(2, 1, 3, MolecularShapes.Angular);
        public static BondAngle Tetrahedral { get; } = new BondAngle(4, 0, 4, MolecularShapes.Tetrahedral);
        public static BondAngle TrigonalPyramidal { get; } = new BondAngle(3, 1, 4, MolecularShapes.TrigonalPyramidal);
        public static BondAngle Bent { get; } = new BondAngle(2, 2, 4, MolecularShapes.Bent);
        public static BondAngle TrigonalBipyramidal { get; } = new BondAngle(5, 0, 5, MolecularShapes.TrigonalBipyramidal);
        public static BondAngle Seesaw { get; } = new BondAngle(4, 1, 5, MolecularShapes.Seesaw);
        public static BondAngle TShaped { get; } = new BondAngle(3, 2, 5, MolecularShapes.TShaped);
        public static BondAngle Octahedral { get; } = new BondAngle(6, 0, 6, MolecularShapes.Octahedral);
        public static BondAngle SquarePyramidal { get; } = new BondAngle(5, 1, 6, MolecularShapes.SquarePyramidal);
        public static BondAngle SquarePlanar { get; } = new BondAngle(4, 2, 6, MolecularShapes.SquarePlanar);
        public static BondAngle PentagonalBipyramidal { get; } = new BondAngle(7, 0, 7, MolecularShapes.PentagonalBipyramidal);
        public static BondAngle PentagonalPyramidal { get; } = new BondAngle(6, 1, 7, MolecularShapes.PentagonalPyramidal);
        public static BondAngle PentagonalPlanar { get; } = new BondAngle(5, 2, 7, MolecularShapes.PentagonalPlanar);
        public static BondAngle SquareAntiprismatic { get; } = new BondAngle(8, 0, 8, MolecularShapes.SquareAntiprismatic);
        public static BondAngle TricappedTrigonalPrismatic { get; } = new BondAngle(9, 0, 9, MolecularShapes.TricappedTrigonalPrismatic);
    }
}
