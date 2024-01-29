using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_2_Multiplication_of_given_range
{
    internal class Program
    {
        static void Main(string[] args)
        {// printing multiplication of given range
            Console.Write("Enter your range:\t");
            int n=int.Parse(Console.ReadLine());
            int multi=1;
            for(int i=1; i<=n; i++)
            {
                multi *= i;
            }
            Console.Write($"Multiplication value upto {n} is {multi}");
            Console.ReadLine();
        }
    }
}
