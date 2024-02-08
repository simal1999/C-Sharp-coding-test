using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_12_Sum_of_squares_of_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {// sum of squares in given range.
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            int sum = 0 ,square;
            for(int i=1; i<=n; i++)
            {
                square = i * i;
                sum += square;
            }
            Console.WriteLine($"The sum of squares upto {n} is {sum}.");
            Console.ReadLine();
        }
    }
}
