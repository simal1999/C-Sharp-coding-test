using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_6_tables
{
    internal class Program
    {
        static void Main(string[] args)
        {// multiplication of given number
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine($"The multiplication of {n} is");
            for (int i=1; i<=12; i++)
            {
                Console.WriteLine($"{n}X{i}={n*i}");
            }
            Console.ReadLine();
        }
    }
}
