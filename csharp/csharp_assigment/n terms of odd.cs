using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace n_terms_of_odd
{//8. Write a program in C# Sharp to display the n terms of odd natural number and their sum.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
            Console.Write("Input number of terms : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("The odd numbers are : ");
            for(i=1;i<=n;i++)
            {
                Console.Write("\n{0}", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.WriteLine("\nThe Sum of odd Natural Number upto {0} terms : {1}", n, sum);
            Console.ReadLine();
        }
    }
}
