using System;

namespace BubbleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Bsort.BubbleSort(arr);
            Console.WriteLine("Sorted array");
            Bsort.printArray(arr);
        }
    }
}
