using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cube_of_given_integer
{//5. Write a program in C# Sharp to display the cube of the number up to given an integer.
    internal class Program
    {
        static void Main(string[] args)
        {
            int n,i;
            Console.Write("Enter the number: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=n;i++)
            {
                int cube = i * i * i;
                Console.WriteLine("Number is : {0} and cube of the {1} is : {2}" , i, i,cube);
                                 //or
               // Console.WriteLine("Number is : {0} and cube of the {1} is : {2}", i, i, (i*i*i));
            }
            Console.ReadLine();
        }
    }
}
