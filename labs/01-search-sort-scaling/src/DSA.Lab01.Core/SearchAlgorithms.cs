using System;

namespace DSA.Lab01
{
    public static class SearchAlgorithms
    {
        public static int LinearSearch(int[] values, int target)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            for (int i = 0; i < values.Length; ++i)
            {
                if (values[i] == target)
                {
                    return i;
                }
            }

            return -1;
        }

        public static int BinarySearch(int[] sortedValues, int target)
        {
            if (sortedValues == null)
            {
                throw new ArgumentNullException(nameof(sortedValues));
            }
            
            int min = 0;
            int max = sortedValues.Length - 1;

            while (min <= max)
            {
                int mid = min + (max - min) / 2;
                
                if(sortedValues[mid] == target)
                    return mid;
                
                if(sortedValues[mid] < target)
                    min = mid + 1;
                else
                    max = mid - 1;
            }
            
            return -1;
        }
    }
}
