using Animals;
using System.Collections.Generic;

namespace Zoos
{
    /// <summary>
    /// The class used to represent the SortHelper class.
    /// </summary>
    public static class SortHelper
    {
        /// <summary>
        /// Does a bubble sort by weight.
        /// </summary>
        /// <param name="animals"> The list of animals being sorted.</param>
        /// <returns> The results of the bubble sort.</returns>
        public static SortResult BubbleSortByWeight(List<Animal> animals)
        {
            return null;
        }

        /// <summary>
        /// Swaps the animals in the list.
        /// </summary>
        /// <param name="animals"> The list of animals.</param>
        /// <param name="index1"> The first value.</param>
        /// <param name="index2"> The second value.</param>
        private static void Swap(List<Animal> animals, int index1, int index2)
        {
            // Set tmp to 1
            Animal tmp = animals[0];

            // Set the 2 to 1.
            animals[0] = animals[1];

            // Set the 1 to 2.
            animals[1] = tmp;
        }
    }
}
