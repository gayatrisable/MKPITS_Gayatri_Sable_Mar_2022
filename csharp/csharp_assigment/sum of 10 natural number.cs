using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_first_10_natural_numbers
{//2. Write a C# Sharp program to find the sum of first 10 natural numbers.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
          
            for ( i = 1; i <= 10; i++) 
            {
              sum = sum + i;
               
                Console.WriteLine( i);
               
            }
            Console.WriteLine("sum of 1st 10 natural number: " + sum);
            Console.ReadLine();
        }
    }
}
