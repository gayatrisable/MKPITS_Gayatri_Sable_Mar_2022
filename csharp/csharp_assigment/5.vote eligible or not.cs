using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.vote_eligible_or_not
{
    internal class Program
    {//5. Write a C# Sharp program to read the age of a candidate and determine whether it is eligible for casting his/her own vote.
        static void Main(string[] args)
        {
            Console.WriteLine("--The age of a candidate and determine whether it is eligible for casting his/her own vote.----");
            int a;
            Console.WriteLine("Enter the candidate age:");
            a=Convert.ToInt32(Console.ReadLine());
            if(a>=18)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("you are not eligible for vote!");
            }
            Console.ReadLine();
        }
    }
}
