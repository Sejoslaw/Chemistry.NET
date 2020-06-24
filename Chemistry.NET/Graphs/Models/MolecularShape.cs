/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;

namespace Chemistry.NET.Graphs.Models
{
    /// <summary>
    /// Describes the shape in which Chemical Compound can be presented.
    /// </summary>
    public partial class MolecularShape
    {
        /// <summary>
        /// In chemistry, defined the total number of neighbors of a central atom in a molecule or ion.
        /// </summary>
        /// <value></value>
        public int CoordinationNumber { get; set; }
        /// <summary>
        /// Ideal bond angles.
        /// </summary>
        /// <value></value>
        public IEnumerable<double> BondAngles { get; set; }
        /// <summary>
        /// A separation of electric charge leading to a molecule or its chemical groups having an electric dipole moment, 
        /// with a negatively charged end and a positively charged end.
        /// </summary>
        /// <value></value>
        public int Polarity { get; }

        public MolecularShape(int coordinationNumber, IEnumerable<double> bondAngles, int polarity)
        {
            CoordinationNumber = coordinationNumber;
            BondAngles = bondAngles;
            Polarity = polarity;
        }
    }
}
