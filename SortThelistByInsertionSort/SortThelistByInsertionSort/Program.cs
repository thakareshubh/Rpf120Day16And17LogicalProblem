using System;

namespace SortThelistByInsertionSort
{
    internal class Program
    {
        public static void Main()
        {
            int[] arr = { 12, 11, 13, 5, 6 };
            InsertionSort ob = new InsertionSort();
            ob.sort(arr);
            InsertionSort.printArray(arr);
        }
    }
}
