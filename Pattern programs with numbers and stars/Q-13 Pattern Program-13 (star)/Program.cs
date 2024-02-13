using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_13_Pattern_Program_13__star_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            *****
             ****
              ***
               **
                *
         */
            Console.Write("Enter number of rows:\t");
            int n=int.Parse(Console.ReadLine());
            for(int i = n; i >= 1; i--)//row index loop
            {
                for(int j = n; j > i; j--)
                {
                    Console.Write(" ");
                }
                for(int k=1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
