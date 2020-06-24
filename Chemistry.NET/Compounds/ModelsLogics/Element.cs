/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using Chemistry.NET.Compounds.Collections;

namespace Chemistry.NET.Elements.Models
{
  public partial class Element
    {
        /// <summary>
        /// Returns new ElementStack for current Element.
        /// </summary>
        /// <param name="count"></param>
        /// <returns></returns>
        public ElementStack ToStack(int count = 1)
        {
            return new ElementStack(this, count);
        }
    }
}
