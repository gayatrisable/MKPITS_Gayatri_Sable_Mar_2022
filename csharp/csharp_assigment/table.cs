using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace table
{//6. Write a program in C# Sharp to display the multiplication table of a given integer.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.Write("Input the number (Table to be calculated : ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("{0} * {1} = {2}", n, i, (n * i));
            }
            Console.ReadLine();
        }
    }
}
