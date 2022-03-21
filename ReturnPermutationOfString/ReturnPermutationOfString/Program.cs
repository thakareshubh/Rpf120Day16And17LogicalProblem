using System;

namespace ReturnPermutationOfString
{
    internal class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       static void Main(string[] args)
        {
            ///permutation by recursion
            string str = "ABC";
            int n=str.Length;
            Permutation.Permute(str, 0, n - 1);

            Console.WriteLine("permutation by itterative method");

            ///permutition by itteration 
            String s = "ABC";

            itteraion.compute(s);

           

        }
    }

    public class Permutation
    {

        /// <summary>
        /// Permutes the specified string.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <param name="initial">The initial.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        public static void Permute(string str,int initial,int end)
        {
            if(initial==end)
            {

                Console.WriteLine(str);

            }
            else
            {
                for(int i=initial;i<end;i++)
                {
                    str = Swap(str, initial, i);
                    Permute(str, initial + 1, end);
                    str = Swap(str, initial, i);
                }
            }
            Console.WriteLine(str);
        }

        /// <summary>
        /// Swaps the specified a.
        /// </summary>
        /// <param name="a"> string value.</param>
        /// <param name="i">The i=porsition 1</param>
        /// <param name="j">The j=position 2</param>
        /// <returns></returns>
        public static string Swap(string a,int i ,int j)
        {
            char temp;
            char [] charArray=a.ToCharArray();
            temp=charArray[i];
            charArray[i]=charArray[j];
            charArray[j]=temp;
            string s= new string(charArray);
            return s;
        }
    }
}

    