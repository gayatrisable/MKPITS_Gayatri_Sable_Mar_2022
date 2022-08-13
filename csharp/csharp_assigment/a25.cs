﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a3.object_prodid_prodname_prodrate___quantity
{//3- create a class product having fields prodid,prodname,prodrate , quantity and methods getproductdata and displayorder
    public class Product
    {
        public int id;
        public string name;
        public int rate;
        public int quantity;


        public void get_customer_data(int id, string name, int rate, int quantity)
        {
            this.id = id;
            this.name = name;
            this.rate = rate;
            this.quantity = quantity;

        }
        public void display_customer_data()
        {
            Console.WriteLine("Enter product id: " + id);
            Console.WriteLine("Enter product name: " + name);
            Console.WriteLine("Enter product rate: " + rate);
            Console.WriteLine("Enter prodct quantity " + quantity);
            Console.WriteLine("total amount: " + (rate * quantity));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pro = new Product();
            Console.Write("Enter product id: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product name: ");
            string name = Console.ReadLine();

            Console.Write("Enter product rate: ");
            int rate = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter product quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            pro.get_customer_data(id, name, rate, quantity);
            Console.WriteLine();
            pro.display_customer_data();
            Console.ReadLine();
        }
    }
}
