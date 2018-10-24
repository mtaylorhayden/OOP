using Animals;
using System.Collections.Generic;
using System.Linq;

namespace Zoos
{
    /// <summary>
    /// The class used to represent the SortHelper class.
    /// </summary>
    public static class SortHelper
    {
        /// <summary>
        /// Sorts the animals names with the Bubble algorithm
        /// </summary>
        /// <param name="animals">The list of animals.</param>
        /// <returns> The sorted result.</returns>
        public static SortResult BubbleSortByName(List<Animal> animals)
        {
            int swapCounter = 0;

            // Make a loop variable to one less than the length of the list and decrement the variable.
            for(int i = animals.Count - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if(animals[j].Name.CompareTo(animals[j + 1].Name) > 0)
                    {
                        // Swap the animals place in the index.
                        SortHelper.Swap(animals, j, j + 1);

                        // Increment the count.
                        swapCounter++;
                    }
                }
            }
            // Using an Object initializer, set the objects values, and return them.
            return new SortResult() { SwapCount = swapCounter, Animals = animals };
        }

        /// <summary>
        /// Does a bubble sort by weight.
        /// </summary>
        /// <param name="animals"> The list of animals being sorted.</param>
        /// <returns> The results of the bubble sort.</returns>
        public static SortResult BubbleSortByWeight(List<Animal> animals)
        {
            // Create a swap counter.
            int swapCounter = 0;

            // Use a for loop to loop backward through the list.
            // Initialize the loop variable to one less than the length of the list and decrement the variable instead of increment.
            for(int i = animals.Count - 1; i > 0; i--)
            {
                // Loop forward as long as the loop variable is less than the outer loop variable.
                for(int j = 0; j < i; j++)
                {
                    // If the weight of the current animal is more than the weight of the next animal, swap the two animals and increment the swap count.
                    if(animals[j].Weight > animals[j + 1].Weight)
                    {
                        // Swap the animals place in the index.
                        SortHelper.Swap(animals,j, j + 1);

                        // Increment the count.
                        swapCounter++;
                    }
                }
            }

            // Using an Object initializer, set the objects values, and return them.
            return new SortResult() { SwapCount = swapCounter, Animals = animals };
        }

        /// <summary>
        /// The class used to sort by selection.
        /// </summary>
        /// <param name="animals"> The list of animals being sorted</param>
        /// <returns> The sorted result.</returns>
        public static SortResult SelectionSortByWeight(List<Animal> animals)
        {
            SortResult result = null;

            // Make a counter.
            int swapCounter = 0;

            // Loop forward through the list.
            for (int i = 0; i < animals.Count - 1; i++)
            {
                // Create a variable and set it to the current animal.
                // This variable should contain the animal with the current minimum weight.
                Animal minimumAnimal = animals[i];

                // Loop through the remaining animals in the list to find the animal with the lowest weight.
                for (int j = i + 1; j < animals.Count; j++)
                {
                    // If the current animal's weight is less than the animal with the lowest weight..
                    if(animals[j].Weight < minimumAnimal.Weight)
                    {
                        // Set the miniumWeight variable to the current animal.
                        minimumAnimal = animals[j];
                    }
                }
                // After finding the animal with the lowest weight.
                // Compare the current animals weight with the minimum weight.
                if (animals[i].Weight != minimumAnimal.Weight)
                {
                    // Swap the two animals.
                    SortHelper.Swap(animals, i, animals.IndexOf(minimumAnimal));

                    // Increment the swap count.
                    swapCounter++;
                }

            }

            // Using an Object initializer, set the objects values, and return them.
            return new SortResult() { SwapCount = swapCounter, Animals = animals };
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
            Animal tmp = animals[index1];

            // Set the 2 to 1.
            animals[index1] = animals[index2];

            // Set the 1 to 2.
            animals[index2] = tmp;
        }
    }
}
