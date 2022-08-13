using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a7.bonous_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 wap to empno, empname , designation calculate and display bonus ie 10000 for manager 5000 for cleark 2000 for peon
            string name, id,des;
            Console.WriteLine("Enter employee id:");
            id = Console.ReadLine();
            Console.WriteLine("Enter employee name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter designation:");
            des = Console.ReadLine();
            if(des=="manager")
            {
                Console.WriteLine("Manager Bonous: "+10000);
            }
            else if (des == "cleark")
            {
                Console.WriteLine("Cleark Bonous: " + 5000);
            }
            else if (des =="peon")
            {
                Console.WriteLine("Peon Bonous: " + 2000);
            }
            else
            {
                Console.WriteLine("please enter valid designation!");
            }
            Console.ReadLine();
        }
    }
}
