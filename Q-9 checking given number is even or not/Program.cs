﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_9_checking_given_number_is_even_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {// checking given number is even or not.
            Console.Write("Enter your number:\t");
            int n=int.Parse(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine($"{n} is even number");
            }
            else
            {
                Console.WriteLine($"{n} not an number.");
            }
            Console.ReadLine();
        }
    }
}
