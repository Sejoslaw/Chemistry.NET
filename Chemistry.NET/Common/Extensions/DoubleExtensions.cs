/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

using static Chemistry.NET.Common.Constants;

namespace Chemistry.NET.Common.Extensions
{
    public static class DoubleExtensions
    {
        /// <summary>
        /// Converts MeV / c^2 into Daltons
        /// </summary>
        /// <param name="mev"></param>
        /// <returns></returns>
        public static double ToDaltons(this double mev)
        {
            return mev / OneDalton;
        }

        /// <summary>
        /// Converts Daltons into MeV / c^2
        /// </summary>
        /// <param name="daltons"></param>
        /// <returns></returns>
        public static double ToMeV(this double daltons)
        {
            return daltons * OneDalton;
        }
    }
}
