using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_7_Pattern_Program_7_based
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          1
          2 3 
          4 5 6 
          7 8 9 10
          */
            Console.Write("Enter your row number:\t");
            int n=int.Parse(Console.ReadLine());
            int s = 1;
            for(int i = 1; i <= n; i++)// row index loop
            {
                for(int j=1;j<=i; j++)// column index loop
                {
                    Console.Write(s + " ");
                    s++;
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
