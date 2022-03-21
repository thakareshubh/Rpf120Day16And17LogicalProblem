using System;

namespace MergeSort
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            int[] arr = { 12, 11, 13, 5, 6, 7 };
            Console.WriteLine("Given Array");
            Merge.printArray(arr);
            Merge ob = new Merge();
            ob.sort(arr, 0, arr.Length - 1);
            Console.WriteLine("\nSorted array");
            Merge.printArray(arr);
        }
    }
}
