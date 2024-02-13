using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_4_Pattern_Program_4
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
         1 2 3 4 5
         1 2 3 4
         1 2 3
         1 2
         1
         */
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());    
            for (int i = 1; i <= n; n--)// row index loop
            {
                for (int j = 1; j <= n; j++)// column index loop
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
