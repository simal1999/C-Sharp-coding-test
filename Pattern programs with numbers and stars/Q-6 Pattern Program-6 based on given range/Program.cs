using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6_Pattern_Program_6_based_on_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          1
          2 2
          3 3 3
          4 4 4 4
          5 5 5 5 5
         */
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            for(int i=1; i<=n; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
