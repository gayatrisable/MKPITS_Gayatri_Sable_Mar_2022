using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a1_object_class_product
{//1- create a class product having fields productid,productname,price and quantity create a constructor with no parameters and method display
    class product
    {
        int productid;
        string productname;
        int price;
        int quantity;
        //creating a constructor with no parameters
        public product()//dynamic input or constant
        {
            Console.WriteLine("Enter Product Id:");
            this.productid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter product Name:");
            this. productname = Console.ReadLine();
            Console.WriteLine("Enter price:");
            this .price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity:");
            this. quantity = Convert.ToInt32(Console.ReadLine());
        }
        public void display()
        {
            Console.WriteLine("product id = " + productid);
            Console.WriteLine("product name = " + productname);
            Console.WriteLine("product price= " + price);
            Console.WriteLine("Quantity = " + quantity);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            product p = new product();//this will call constructor automatically
            p.display();
            Console.ReadLine();
        }
    }
}
