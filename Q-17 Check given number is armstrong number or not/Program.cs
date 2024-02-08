using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_17_Check_given_number_is_armstrong_number_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {//check given number is Armstrong number or not 
         // example number is 153.number length is 3. so 1^3+5^3+3+3=153.
            Console.Write("Enter your number:\t");
            string a = Console.ReadLine();
            int b = int.Parse(a);
            int rem = 0,s=b,sum=0,rev=0;
            while (s != 0)
            {
                rem = s % 10;
                sum += (int)(Math.Pow(rem, a.Length));
                s /=10;
            }
            if (b == sum)
            {
                Console.WriteLine($"{b} is Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{b} is not Armstrong number.");
            }
            Console.ReadLine();
        }
    }
}
