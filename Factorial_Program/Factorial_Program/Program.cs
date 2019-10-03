using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial_Program
{
    public class FactorialExample
    {
        public static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter any Number: ");
            number = int.Parse(Console.ReadLine());
            for (int j = 1; j <= number; j++)
            {
                fact = fact * j;
            }
            Console.WriteLine("Factorial of "+ number +" is: "+ fact);
        }
    }
}
