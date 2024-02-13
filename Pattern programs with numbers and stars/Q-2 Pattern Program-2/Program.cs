using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2_Pattern_Program_2
{
    internal class Program
    {
        static void Main(string[] args)
        
        {/*
         1
         1 2
         1 2 3
         1 2 3 4 
         1 2 3 4 5
         */
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 1; i <= n; i++)//row index loop
            {
                for(int j=1; j <= i; j++)//column index loop
                {
                    Console.Write(j +" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
