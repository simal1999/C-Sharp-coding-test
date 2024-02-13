using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_9_Pattern_Program_9_based_on_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          21 20 19 18 17 16
          15 14 13 12 11
          10 9 8 7
          6 5 4
          3 2 
          1
         */
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            Console.Write("Enter your numer of rows:\t");
            int s=int.Parse(Console.ReadLine());
            for (int i = s; i >= 1; i--) 
            {
                for(int j = i; j >= 1; j--)
                {
                    Console.Write(n-- + " ");
                    if (n == 0)
                        break;
                }
                Console.WriteLine();
                if (n == 0)
                    break;
            }
            Console.ReadLine();
           
        }
    }
}
