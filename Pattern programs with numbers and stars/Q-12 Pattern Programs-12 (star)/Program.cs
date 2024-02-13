using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12_Pattern_Programs_12__star_
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
            for(int i=n; i>=1; i--)
            {
                for(int j=1; j<=i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
