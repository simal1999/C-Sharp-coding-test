using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_16_palindrome_number_upto_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {//palindrome number upto given range.
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"The palindrome numbers upto {n} are:");
            for (int i=1; i<=n; i++)
            {
                int rem = 0,rev=0, s = i; 
                while (s != 0)
                {
                    rem = s % 10;
                    rev = (rev * 10) + rem;
                    s = s / 10;
                }
                if (i == rev)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
