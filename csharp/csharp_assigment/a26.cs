﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a4.object_fields_make_model_and_method
{//4- create a class car having fields make,model and method getcardata and displaycardata
    public class Car
    {
        public string company_name;
        public string model;
        public void getcardata(string company_name, string model)
        {
            this.company_name = company_name;
            this.model = model;
        }
        public void displaycardata()
        {
            Console.WriteLine("Company name: " + company_name);
            Console.WriteLine("model: " + model);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Console.Write("enter company name: ");
            string company_name = Console.ReadLine();
            Console.Write("enter model: ");
            string model = Console.ReadLine();
            car.getcardata(company_name, model);
            Console.WriteLine("");
            car.displaycardata();
            Console.ReadLine();
        }
    }
}
