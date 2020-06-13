/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Collections
{
    /// <summary>
    /// Represents general definition of a Stack used throughout the library.
    /// </summary>
    public interface IChemicalStack
    {
        /// <summary>
        /// Number of items on the Stack.
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Increases / Decreases the amount of items on the current Stack.
        /// </summary>
        /// <param name="count"></param>
        void IncreaseStackSize(int count = 1);
    }
}
