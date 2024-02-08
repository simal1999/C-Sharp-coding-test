using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {// sum of squares of an given digit.
            Console.Write("Enter yyour number:\t");
            int n=int.Parse(Console.ReadLine());
            int sum = 0,rem;
            while (n != 0)
            {
                rem = (n % 10);
                sum =sum+(rem*rem);
                n = n/10;
            }            
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
