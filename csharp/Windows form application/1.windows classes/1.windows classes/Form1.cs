﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.windows_classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            student s = new student();
            s.rno = Convert.ToInt32(textBox1.Text);
            s.name = textBox2.Text;
            s.email = textBox3.Text;
            s.mobileno = Convert.ToInt64(textBox4.Text);
            StringBuilder sb = new StringBuilder();
            sb.Append("Roll Number : " + s.rno + "\n");
            sb.Append("Student Name : " + s.name + "\n");
            sb.Append("email :" + s.email + "\n");
            sb.Append("Mobile no : " + s.mobileno + "\n");
            label5.Text = sb.ToString();

        }
    }
}
