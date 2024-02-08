using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_23_min_and_max_digit_in_given_number
{
    internal class Program
    {
        static void Main(string[] args)
        {//min and max digit in given number.
            Console.WriteLine("Enter your number:");
            int n=int.Parse(Console.ReadLine());//5673
            int max=0, min=9,rem=0;
            while (n != 0)
            {
                rem = n % 10;
                if (rem > max)
                {
                    max = rem;
                }
                if(rem<min)
                {
                    min = rem;
                }
                n /= 10;
            }
            Console.WriteLine($"min value is {min} and max value is {max}.");
            Console.ReadLine();
        }
    }
}
