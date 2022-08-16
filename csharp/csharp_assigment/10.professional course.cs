using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.a_professional_course
{//10. Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria:
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, p, c;
            Console.WriteLine("Enter the Maths marks");
            m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maths marks");
            p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Maths marks");
            c = Convert.ToInt32(Console.ReadLine());
            int total = m + p + c;
            if(total>=180 && m >= 65 && p >= 55 && c >= 50)
            {
                Console.WriteLine("The candidate is eligible for admission!");
            }
            else if(m+p>=140)
            {
                Console.WriteLine("The candidate is eligible for admission!");

            }
            else {
                Console.WriteLine("The candidate is not eligible for admission!");
            }
            Console.ReadLine();
        }
    }
}
