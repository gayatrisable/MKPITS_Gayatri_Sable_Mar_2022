using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a4.product_class
{//4-create a class product having fields productname,quantity,price and shipping charges create a constructor with no parameters and create another parameterized constructor with 4 parameters
    class product
    {
        string product_name;
        int quantity;
        int price;
        int shipping_charages;

        public product()
        {
            //product_name = "chocholate";//it is used to constant method
            //quantity = 25;
           // price= 1000;
            //shipping_charages = 10;
            Console.WriteLine("Enter product name:");//it is dynamic method
            this.product_name = Console.ReadLine();
            Console.WriteLine("enter quantity");
            this.quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter price");
            this.price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter shipping charges");
            this.shipping_charages = Convert.ToInt32(Console.ReadLine());


        }
        public product(string proname, int quan, int pri, int shipp)
        {
            this.product_name = proname;
            this.quantity = quan;
            this.price = pri;
            this.shipping_charages = shipp;
        }

        public void display()
        {
            Console.WriteLine("Prpduct Name: " + product_name);
            Console.WriteLine("Quantity: " + quantity);
            Console.WriteLine("product Price: " + price);
            Console.WriteLine("shipping Charges: " + shipping_charages);

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            product pro = new product();
            pro.display();
            Console.WriteLine("--------------------1st product details");
            product pro1 = new product("chocholate",5,35,5);
            pro1.display();
            Console.ReadLine();
        }
    }
}
