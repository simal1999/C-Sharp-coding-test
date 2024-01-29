using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_3_Factorial_of_a_number
{
    internal class Program
    {
        static void Main(string[] args)
        {// factorial of an given number.
            Console.WriteLine("Enter your number");
            int n=int.Parse(Console.ReadLine());
            int multi = 1;
            if (n == 0 || n == 1)
            {
                Console.WriteLine($"The factorial of {n} is 1");
            }
            else if (n < 0)
            {
                while (n < 0)
                {
                    Console.WriteLine("Enter positive numbers only");
                    n=int.Parse(Console.ReadLine()) ;
                }
                if (n == 0 || n == 1)
                {
                    Console.WriteLine($"The factorial of {n} is 1");
                }
            }
            else
            {
                for (int i = n; i >= 1; i--)
                {
                    multi *= i;
                }
                Console.WriteLine($"The factorial of {n} is {multi}");
            }
            Console.ReadLine();
        }
    }
}
