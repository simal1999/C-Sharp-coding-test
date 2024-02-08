using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Q_22_number_of_prime_numbers_display_in_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {//number of prime numbers in given range.
            Console.WriteLine("Enter your number: ");
            int n=int.Parse(Console.ReadLine());//10
            int count = 0,cal=0,s=2;
            for(int i=2; i<=s; i++)
            {
                count = 0;
                for(int j=2; j<i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count == 0)
                {
                    Console.Write(i + " ");
                    cal++;
                }
                if (cal == n)
                {
                    break;
                }
                s++;
             
            }
            Console.ReadLine();
        }
    }
}
