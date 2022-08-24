using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_nth_natural_number
{//3. Write a program in C# Sharp to display n terms of natural number and their sum.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum =0;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n; i++) 
            {
                sum = sum + i;
                Console.WriteLine(i);

            }
            Console.Write("The Sum of Natural Number upto " +n+ " terms is :" + sum);
            Console.ReadLine();
        }
    }
}
