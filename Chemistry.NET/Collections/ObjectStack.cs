/// <summary>
/// Author: Krzysztof Dobrzyński
/// Project: Chemistry.NET
/// Source: https://github.com/Sejoslaw/Chemistry.NET
/// </summary>

namespace Chemistry.NET.Collections
{
    /// <summary>
    /// Represents a stack in which the Object is always the same but only the number of them change.
    /// </summary>
    /// <typeparam name="TObjectType"> Type of the objects on the Stack. </typeparam>
    public partial class ObjectStack<TObjectType>
    {
        /// <summary>
        /// Object stored on Stack.
        /// </summary>
        public TObjectType Object { get; }
        /// <summary>
        /// Number of objects on the Stack.
        /// </summary>
        public int Count { get; private set; }

        public ObjectStack(TObjectType @object, int count)
        {
            Object = @object;
            Count = count;
        }
        
        /// <summary>
        /// Adds more objects to the Stack.
        /// </summary>
        /// <param name="count"></param>
        public void Add(int count)
        {
            Count += count;
        }
    }
}
