using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_20_Given_number_converts_into_single_digit
{
    internal class Program
    {
        static void Main(string[] args)
        {//given number converts into single digit/
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());//5643
            while (n >= 10)
            {
                int sum = 0;
                while (n != 0)
                {
                    sum += n % 10;
                    n /= 10;
                }
                n = sum;// sum is assigning to n
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
