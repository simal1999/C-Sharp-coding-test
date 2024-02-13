using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_14_Pattern_Programs_14__stars_
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            *
           ***
          *****
         *******
      */
            Console.Write("Enter number of last row elements:\t");
            int n=int.Parse(Console.ReadLine());
            int gap;
            for(int i=1; i<=n; i++)
            {
               gap=(n-i)/2;
                if (i % 2 == 0)
                {
                    continue;
                }
                for(int j=1; j<=gap; j++)
                {
                    Console.Write(" ");
                }
                for(int j=1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
