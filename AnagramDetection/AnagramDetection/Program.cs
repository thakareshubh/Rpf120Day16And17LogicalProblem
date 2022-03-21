using System;
using System.Collections;

namespace AnagramDetection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creat and initialize new ArrayList

            ArrayList str1 = new ArrayList();
            str1.Add('t');
            str1.Add('e');
            str1.Add('s');
            str1.Add('t');
            // create and initialize new ArrayList
            ArrayList str2 = new ArrayList();
            str2.Add('t');
            str2.Add('t');
            str2.Add('e');
            str2.Add('w');

            // Function call
            if (CheckAnagram.AreAnagram(str1, str2))
            {
                Console.WriteLine("The two strings are"
                                  + " anagram of each other");
            }
            else
            {
                Console.WriteLine("The two strings are not"
                                  + " anagram of each other");
            }
        }
    }
    }

