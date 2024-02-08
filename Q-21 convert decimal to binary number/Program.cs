
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q_21_convert_decimal_to_binary_number
{
    internal class Program
    {
        static void Main(string[] args)
        {//convert decimal to binary number.
            Console.Write("Enter your number to convert into binary: ");
            int n=int.Parse(Console.ReadLine());//10
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            int s = 0;
            while (n != 0)
            {
               s = n % 2;
               sb.Append(s);
               s = n / 2;
               n = s;
            }
            for(int i = sb.Length-1; i >=0; i--) 
            {
                sb2.Append(sb[i]);
            }
            Console.WriteLine(sb2);
            Console.ReadLine();
        }
    }
}
