using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.person_height
{//7. Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
    internal class Program
    {
        static void Main(string[] args)
        {
            float h;
            Console.WriteLine("Enter person height:");
            h = Convert.ToSingle(Console.ReadLine());
            if(h<150.0)
            {
                Console.WriteLine("The person is Dwarf.");
            }
            else if (h >=150.0 && h<=165.0)
            {
                Console.WriteLine("The person is average heighted.");
            }
            else if (h >= 165.0 && h>195.0)
            {
                Console.WriteLine("The person is taller");
            }
            else 
            {
                Console.WriteLine("The person is abrormal height.");
            }
            Console.ReadLine();
        }
    }
}
