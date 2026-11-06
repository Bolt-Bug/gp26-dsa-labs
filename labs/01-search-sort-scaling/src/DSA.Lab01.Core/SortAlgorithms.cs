using System;

namespace DSA.Lab01
{
    public static class SortAlgorithms
    {
        public static void InsertionSort(int[] values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            // TODO: Sort the array in ascending order using insertion sort.
            //
            // Think of values[0..i-1] as the already-sorted part.
            // For each next value:
            // 1. Store the value you want to insert.
            // 2. Shift larger values one position to the right.
            // 3. Put the stored value into the gap.

            int[] sortedValues = values;
            for (int i = 1; i < values.Length; i++)
            {
                for (int j = 1; j < values.Length; j++)
                {
                    if (sortedValues[j] < sortedValues[j - 1])
                    {
                        int newMin = sortedValues[j];
                        int oldMin = sortedValues[j - 1];
                    
                        sortedValues[j - 1] = newMin;
                        sortedValues[j] = oldMin;
                    }
                }
            }
        }
    }
}
