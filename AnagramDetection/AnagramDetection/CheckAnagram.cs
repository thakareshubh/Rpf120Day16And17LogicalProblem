using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AnagramDetection
{
    internal class CheckAnagram
    {
        /// <summary>
        /// Method two check wherethe two string are anagram are not
        /// </summary>
        /// <param name="str1">The STR1.</param>
        /// <param name="str2">The STR2.</param>
        /// <returns></returns>
        public static bool AreAnagram(ArrayList str1,ArrayList str2)
        {
            //Get the lenght of two string
            int n1 = str1.Count;
            int n2 = str2.Count;
            
            ///If both the string are not same 
            /// then they cannot be anagram

            if(n1!=n2)
            {
                return false;
            }

            //sort both the string

            str1.Sort();
            str2.Sort();

            // Compair sorted string

            for(int i = 0; i < n1; i++)
            {
                if(str1[i]!=str2[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
