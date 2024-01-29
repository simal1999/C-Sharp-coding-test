using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_1_Sum_of_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sum of given range
            Console.WriteLine("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1; i<=n; i++)
            {
                sum += i;
            }
            Console.WriteLine($"The sum of given range is {sum}");
            Console.ReadLine();
        }
    }
}
