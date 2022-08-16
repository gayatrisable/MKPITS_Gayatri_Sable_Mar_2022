using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.check_tempeature
{//13. Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below :
    internal class Program
    {
        static void Main(string[] args)
        {
            float temp;
            Console.WriteLine("Enter Temperature:");
            temp = Convert.ToSingle(Console.ReadLine());
            if(temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if(temp <= 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temp <20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temp <30)
            {
                Console.WriteLine("Normal in Temp");
            }
            else if (temp <  40)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temp >=40)
            {
                Console.WriteLine("Its Very Hot");
            }
            //else
           // {
            //    Console.WriteLine("not for human");
           // }
            Console.ReadLine();
        }
    }
}
