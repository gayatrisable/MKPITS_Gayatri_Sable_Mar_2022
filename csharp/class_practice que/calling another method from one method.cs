﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calling_another_method_from_one_method
{
    class Book

    {
        int bookid;
        String title, author;
        int price;

        public void getdata()
        {
            bookid = 1;
            title = "oracle";
            author = "james";
            price = 200;

        }
        //method overloaded
        public void getdata(int bookid)
        {
            this.bookid = bookid;
            getdata(bookid, "html");

        }
        public void getdata(int bookid, String title)
        {
            this.bookid = bookid;
            this.title = title;
            getdata(bookid, title, "amitabh");

        }
        public void getdata(int bookid, String title, String author)
        {
            this.bookid = bookid;
            this.title = title;
            this.author = author;
            getdata(bookid, title, author, 234);

        }
        public void getdata(int bookid, String title, String author, int price)
        {

            this.bookid = bookid;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void display()
        {
            Console.WriteLine("book id = " + bookid);
            Console.WriteLine("book title = " + title);
            Console.WriteLine("book author= " + author);
            Console.WriteLine("price = " + price);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book();
            b.getdata(899);
            b.display();
            Console.WriteLine("-----------------book1 details ----------");

            Console.ReadLine();
        }
    }
}
