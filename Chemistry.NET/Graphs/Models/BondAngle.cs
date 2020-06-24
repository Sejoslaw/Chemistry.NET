/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Graphs.Models
{
    public class BondAngle
    {
        public int AtomsBondedToCentralAtom { get; }
        public int LonePairs { get; }
        public int ElectronDomains { get; }
        public MolecularShape Shape { get; }

        public BondAngle(int atomsBondedToCentralAtom, int lonePairs, int electronDomains, MolecularShape shape)
        {
            AtomsBondedToCentralAtom = atomsBondedToCentralAtom;
            LonePairs = lonePairs;
            ElectronDomains = electronDomains;
            Shape = shape;
        }
    }
}
