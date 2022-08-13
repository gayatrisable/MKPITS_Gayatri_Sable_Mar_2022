using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a._12_empolyee_by_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 wap to empno, empname , dsesignation calculate and display bonus ie 10000 for manager 5000 for clerk 2000 for peon by switch
            
            string name, des;
            Console.WriteLine("enter Employee name");
            name = Console.ReadLine();

            Console.WriteLine("enter Designation");
            des = Console.ReadLine();
            switch (des)
            {
                case "manager":
                    Console.WriteLine("Bonus: 10000");
                    break;
                case "clerk":
                    Console.WriteLine("Bonus: 5000");
                    break;
                case "peon":
                    Console.WriteLine("Bonus: 2000");
                    break;
                default:
                    Console.WriteLine("Invalid designation");
                    break;
            }
            Console.ReadLine();
        }   
    }
}
