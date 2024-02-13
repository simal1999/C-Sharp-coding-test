using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11_Pattern_Programs_11__star_
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
            Console.Write("Enter your rows:\t");
            int n=int.Parse(Console.ReadLine());//6
            for(int i=n;i>=1;i--)//row index loop
            {
                for(int j = 1; j < i; j++)//space loop
                {
                    Console.Write(" ");
                }
                for(int  k = n; k >= i; k--)//column index loop
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
          
        }
    }
}
