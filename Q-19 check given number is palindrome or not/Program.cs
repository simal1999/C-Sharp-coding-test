using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_19_check_given_number_is_palindrome_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {// check given number is palindrome or not.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            int s = n, a = 0, b = 0;
            while (s != 0)
            {
                a = s % 10;//it gives remainder
                b = (b * 10) + a;// number is reversing here.
                s/=10;
            }
            if(n==b)
            {
                Console.WriteLine($"{n} is Palindrome Number");
            }
            else
            {
                Console.WriteLine($"{n} is not a palindrome Number");
            }
            Console.ReadLine();
        }
    }
}
