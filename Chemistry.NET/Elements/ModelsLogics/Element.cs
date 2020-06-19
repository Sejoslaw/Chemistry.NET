/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using System.Collections.Generic;
using System.Linq;

namespace Chemistry.NET.Elements.Models
{
    public partial class Element
    {
        /// <summary>
        /// Returns the oxidation states / ions of the current Element.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Ion> GetOxidationStates()
        {
            var states = OxidationStates.Split(", ");
            return states
                .Select(state => new Ion(this, int.Parse(state)))
                .ToList();
        }
    }
}
