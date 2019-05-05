namespace CartesianProductLibrary
{
    /// <summary>
    /// A representation of an ordered pair
    /// </summary>
    /// <typeparam name="Tx">The data type of the first object</typeparam>
    /// <typeparam name="Ty">The data type of the second object</typeparam>
    public class OrderedPair<Tx, Ty>
    {
        /// <summary>
        /// The 'x' value of the ordered pair
        /// </summary>
        Tx X { get; set; }

        /// <summary>
        /// The 'y' value of the ordered pair
        /// </summary>
        Ty Y { get; set; }

        /// <summary>
        /// The constructor for an ordered pair
        /// </summary>
        /// <param name="x">The 'x' value</param>
        /// <param name="y">The 'y' value</param>
        public OrderedPair(Tx x, Ty y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Return the string representation of an ordered pair
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return X.ToString() + "," + Y.ToString();
        }
    }
}
