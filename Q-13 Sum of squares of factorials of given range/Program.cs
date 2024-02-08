using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_13_Sum_of_squares_of_factorials_of_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {// sum of factorial in a given range.
         // example. range5, 5!= 5!+4!+3!+2!+1!.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            int multi = 1, sum = 0;
            for(int i = n; i >= 1; i--)
            {
                multi = 1;
                for(int j=i; j >= 1; j--)
                {
                    multi *= j;
                }
                sum += multi;
            }
            Console.WriteLine($"The of factorials upto {n} is {sum}.");
            Console.ReadLine();
        }
    }
}
