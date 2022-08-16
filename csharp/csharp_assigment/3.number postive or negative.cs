using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.number_postive_and_negative
{
    internal class Program
    {//3. Write a C# Sharp program to check whether a given number is positive or negative.
        static void Main(string[] args)
        {
            Console.WriteLine("--------------- check whether a given number is positive or negative.-------------");
            int a;
            Console.WriteLine("Enter the number:");
            a = Convert.ToInt32(Console.ReadLine());
            if(a>=0)
            {
                Console.WriteLine(a + " is postive");
            }
            else
            {
                Console.WriteLine(a + " is Negative");
            }
            Console.ReadLine();
        }
    }
}
