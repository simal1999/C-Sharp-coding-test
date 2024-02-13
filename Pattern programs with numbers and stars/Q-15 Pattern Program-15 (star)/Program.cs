using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_15_Pattern_Program_15__star_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
                    *******
                     *****
                      ***
                       *
         */
            Console.Write("Enter first row number of elements:\t");
            int n=int.Parse(Console.ReadLine());
            int s = 1;//space index value
            for(int i = n; i >= 1; i--)
            {
                if (i%2==0)
                    continue;
                for(int j = 1; j < s; j++)
                {
                    Console.Write(" ");
                }
                for(int k=i; k >= 1; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                s++;
            }
            Console.ReadLine();
        }
    }
}
