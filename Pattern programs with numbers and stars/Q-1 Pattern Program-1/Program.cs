using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_Pattern_Program_1
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
            Console.Write("Enter your numer:\t");
            int n=int.Parse(Console.ReadLine());//5
            for(int i=1; i <= n; i++)//row index loop
            {
                for(int j=1; j <= i; j++)//cloumn index loop
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
