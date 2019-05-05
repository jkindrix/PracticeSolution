using System.Collections.Generic;

namespace CartesianProductLibrary
{
    /// <summary>
    /// A representation of a data set
    /// </summary>
    /// <typeparam name="T">The type of data in the set.
    /// (e.g. 'int', 'string', etc...)</typeparam>
    public class Set<T>
    {
        /// <summary>
        /// A list containing all the elements of the set
        /// </summary>
        public List<T> Elements { get; set; } = new List<T>();

        /// <summary>
        /// Create an empty Set
        /// </summary>
        public Set()
        {

        }

        /// <summary>
        /// Create a set using a list of elements
        /// </summary>
        /// <param name="elements">A list of elements to place in the Set</param>
        public Set(List<T> elements)
        {
            Elements = elements;
        }
    }
}
