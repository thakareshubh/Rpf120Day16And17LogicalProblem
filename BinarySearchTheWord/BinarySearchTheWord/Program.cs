using System;

namespace BinarySearchTheWord
{
    internal class Program
    
    {

        /// <summary>
        /// Binaries the search.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="x">The x.</param>
        /// <returns></returns>
        static int binarySearch(String[] arr, String x)
        {
            int l = 0, r = arr.Length - 1;
            while (l <= r)
            {
                int m = l + (r - l) / 2;

                int res = x.CompareTo(arr[m]);

                // Check if x is present at mid
                if (res == 0)
                    return m;

                // If x greater, ignore left half
                if (res > 0)
                    l = m + 1;

                // If x is smaller, ignore right half
                else
                    r = m - 1;
            }

            return -1;
        }

       
        public static void Main(String[] args)
        {
            String[] arr = { "contribute", "geeks", "ide", "practice" };
            String x = "ide";
            int result = binarySearch(arr, x);

            if (result == -1)
                Console.WriteLine("Element not present");
            else
                Console.WriteLine("Element found at "
                                + "index " + result);
        }
        
    }
}

