namespace CartesianProductLibrary
{
    /// <summary>
    /// A representation of a cartesian product of two sets
    /// </summary>
    /// <typeparam name="Sx">The data type of set A</typeparam>
    /// <typeparam name="Sy">The data type of set B</typeparam>
    public class CartesianProduct<Sx, Sy>
    {
        /// <summary>
        /// A set of ordered pairs to represent the resulting product 
        /// </summary>
        public Set<OrderedPair<Sx, Sy>> ResultSet { get; set; } = new Set<OrderedPair<Sx, Sy>>();

        /// <summary>
        /// The constructor for the CartesianProduct class
        /// </summary>
        /// <param name="setA">The first set (Set A)</param>
        /// <param name="setB">The second set (Set B)</param>
        public CartesianProduct(Set<Sx> setA, Set<Sy> setB) 
        {
            foreach (Sx x in setA.Elements)
            {
                foreach (Sy y in setB.Elements)
                {
                    ResultSet.Elements.Add(new OrderedPair<Sx, Sy>(x, y));
                }
            }
        }
    }
}
