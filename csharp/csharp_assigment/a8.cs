using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a8.product_50_dissount_if_else_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wap to accept productname, productrate, quantity calculate totalamount, discount ie 50 % if totalamount > 2000 else discount = 10 % of total amount do with if
            string pro;
            int q, r;
            Console.WriteLine("Enter product Name:");
            pro = Console.ReadLine();
            Console.WriteLine("Quantity:");
            q = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Product Rate:");
            r = Convert.ToInt32(Console.ReadLine());
            int total = r * q;
            Console.WriteLine("Product Name: " + pro);
            Console.WriteLine("total= " + total);
            
            if(total>2000)
            {
                float a = total - (total * 50 / 100);
                
                Console.WriteLine("toatl Amount: " +a);
            }
            else 
            {
                float b = total -(total* 10 / 100);

                Console.WriteLine("toatl Amount: " + b);
            }

            Console.ReadLine();
        }
    }
}
