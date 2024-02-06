using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_10_sum_of_even_nubers_in_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your range to display even numbers only :\t");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int count = 0;
            Console.WriteLine("The list of even numbers are: ");
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    count += 1;
                    sum += i;
                }
            }
            Console.WriteLine($"The number of even numbers in given range are {count}.");
            Console.WriteLine($"The sum of even numbers in given range are {sum}.");
            Console.ReadLine();
        }
    }
}
