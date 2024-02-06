using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_7_check_given_number_is_prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {//checking given number is prime or not.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            int count = 0;
            for(int i=2;i<n;i++)
            {
                if (n % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count == 0)
            {
                Console.WriteLine($"{n} is a prime number");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number");
            }
            Console.ReadLine();
        }
    }
}
