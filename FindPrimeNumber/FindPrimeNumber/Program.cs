using System;

namespace FindPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prime(0, 1000);
            
        }

        public static int Prime(int num1,int num2)
        {
            for (int i = num1 + 1; i < num2; ++i)
            {
               int flag_var = 0;
                for (int j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag_var = 1;
                        break;
                    }
                }
                if (flag_var == 0)
                    Console.Write(i +" ");
            }
            return 0;
        }
    }
}
