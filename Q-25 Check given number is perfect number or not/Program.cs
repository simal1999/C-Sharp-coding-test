using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_25_Check_given_number_is_perfect_number_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {// checking given number is perfect or not
         // perfect number means sum of factors of an number excluding the given number.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i=1; i < n; i++)
            {
                if(n%i == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            if (sum == n)
                Console.Write($"{n} is perfect number.{sum}");
            else
                Console.Write($"{n} is not perfect number.");
            Console.ReadLine();
        }
    }
}
