using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_and_average
{//4. Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n,sum=0;
            double avg;
            Console.WriteLine("------------Enter the 10 Number-------");
            for (i=1;i<=10;i++)
            {
                Console.Write("NUMBER is {0} : ",i);
                n = Convert.ToInt32(Console.ReadLine());
                sum = sum +n;
            }
            avg = sum / 10.0;
            Console.Write("the sum of 10 number is : " + sum);
            Console.Write("\nthe average of sum: " + avg);
            Console.ReadLine();
        }
    }
}
