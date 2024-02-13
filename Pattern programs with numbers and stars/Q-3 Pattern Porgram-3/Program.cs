using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3_Pattern_Porgram_3
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          5 5 5 5 5
          4 4 4 4 
          3 3 3 
          2 2 
          1
         */
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            for(int i = n; i >= 1; i--)//row index loop
            {
                for(int j=1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
