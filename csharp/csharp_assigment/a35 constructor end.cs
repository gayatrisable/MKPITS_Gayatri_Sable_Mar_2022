using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a5.constructor_class_student
{//6 create a class student having fields rno,name,course,fees create a method getdata with no parameters , create overloaded method with 2 parameters, 3 parameters, 4 parameters and display method.
    class student
    {
        int roll_no;
        string name, course;
        int fees;

        public void getdata()
        {
            roll_no = 1;
            name= "mena";
            course = "web designer";
            fees = 200;

        }
        //method overloaded
       // public void getdata(int bookid)
        //{
            //this.bookid = bookid;

        //}
        public void getdata(int roll_n, string name)
        {
            this.roll_no = roll_n;
            this.name = name;

        }
        public void getdata(int roll_n, string name,string course)
        {
            this.roll_no = roll_n;
            this.name = name;
            this.course = course;

        }
        public void getdata(int roll_n, string name, string course,int price)
        {
            this.roll_no = roll_n;
            this.name = name;
            this.course = course;
            this.fees = price;
        }
        public void display()
        {
            Console.WriteLine("Student Roll NO = " + roll_no);
            Console.WriteLine("Student Name = " + name);
            Console.WriteLine("Course= " + course);
            Console.WriteLine("fees of course = " + fees);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // student b = new student();
           // b.getdata();
           // b.display();
            Console.WriteLine("-----------------1st student details ----------");
            student b1 = new student();
            b1.getdata(1, "Gayatri");
            b1.display();

            Console.WriteLine("-----------------2nd student details ----------");
            student b2 = new student();
            b2.getdata(2, "neha", "web development");
            b2.display();

            Console.WriteLine("-----------------3rd student details ----------");

            student b3 = new student();
            b3.getdata(3, "Priyanka", "fullstack developer", 50000);
            b3.display();

            Console.WriteLine("-----------------4th student details ----------");

            Console.ReadLine();
        }
    }
}
