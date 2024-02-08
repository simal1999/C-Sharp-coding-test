using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_11_sum_of_odd_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {//sum of odd number in given range.
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            int count = 0, sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if(i%2 != 0)
                {
                    Console.WriteLine(i);
                    count++;
                    sum += i;
                }
            }
            Console.WriteLine($"The number of odd numbers upto {n} are {count}.");
            Console.Write($"The sum of odd numbers upto {n} is {sum}.");
            Console.ReadLine();
        }
    }
}
