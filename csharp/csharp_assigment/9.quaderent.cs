using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.quadrant
{//9. Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter the x co-ordinate:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the x co-ordinate:");
            y = Convert.ToInt32(Console.ReadLine());
            if(x>0 && y>0)
            {
                Console.WriteLine("The coordinate point    lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point  lies in the secound quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The coordinate point lies in the third quadrant.");
            }
            else if (x == 0 && y== 0)
            {
                Console.WriteLine("The coordinate point lies in origin.");
            }
            else
            {
                Console.WriteLine("The coordinate point lies in the fourth quadrant.");
            }
            Console.ReadLine();
        }
    }
}
