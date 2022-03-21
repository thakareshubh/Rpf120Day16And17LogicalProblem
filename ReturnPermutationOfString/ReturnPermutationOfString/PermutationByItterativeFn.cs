﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnPermutationOfString
{
   public class itteraion
    {
        // Utility function to swap the characters in a character array
        private static void swap(char[] arr, int i, int j)
        {
            char c = arr[i];
            arr[i] = arr[j];
            arr[j] = c;
        }

        // Utility function to reverse a char array between specified indices
        private static void reverse(char[] arr, int i, int j)
        {
            // do till two endpoints intersect
            while (i < j)
            {
                swap(arr, i++, j--);
            }
        }

        // Iterative function to find permutations of a string 
        public static void compute(String str)
        {
            // base case
            if (str == null || str.Length == 0)
            {
                return  ;
            }

            // base case
            if (str.Length == 1)
            {
                Console.WriteLine(str);
                return;
            }

            // sort the string in a natural order
            char[] chars = str.ToCharArray();
            Array.Sort(chars);

            // get length of the string
            int n = str.Length;

            while (true)
            {
                // print the current permutation
                string p = new string(chars);
                Console.WriteLine((p) + " ");

                /* The following code will rearrange the string to the next
                   lexicographically ordered permutation (if any) or return if
                   we are already at the highest possible permutation */

                // Find the largest index `i` such that `chars[i-1]` is less than `chars[i]`
                int i = n - 1;
                while (chars[i - 1] >= chars[i])
                {
                    // if `i` is the first index of the string, we are
                    // already at the last possible permutation
                    // (string is sorted in reverse order)
                    if (--i == 0)
                    {
                        return;
                    }
                }

                // find the highest index `j` to the right of index `i` such that
                // `chars[j] > chars[i-1]` (`chars[i…n-1]` is sorted in reverse order)

                int j = n - 1;
                while (j > i && chars[j] <= chars[i - 1])
                {
                    j--;
                }

                // swap character at index `i-1` with index `j`
                swap(chars, i - 1, j);

                // reverse substring `chars[i…n-1]`
                reverse(chars, i, n - 1);
            }
        }

       
    }



}

