using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10_Pattern_Programs__star_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          
            *
            **
            ***
            ****
            *****
            ******
         */
            Console.Write("Enter number of rows:\t");
            int n=int.Parse(Console.ReadLine());
            for(int i=1;i<=n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
