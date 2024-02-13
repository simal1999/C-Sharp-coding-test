using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_8_Pattern_Program_8_based_on_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
         1
         2 3
         4 5 6 
         7 8 9 10
         11 12 13 14 15
         16 17 18 19 20 21
         */
            Console.Write("Enter your row number:\t");
            int s=int.Parse(Console.ReadLine());//21
            int n = 1;
            for(int i = 1; i <= s; i++)//row index loop
            {
                for(int j=1;j<=i;j++)
                {
                    if (n == s+1)
                    {
                        break;
                    }
                    Console.Write(n+" ");
                    n++;
                }
                Console.WriteLine();
                if (n == s+1)
                {
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
