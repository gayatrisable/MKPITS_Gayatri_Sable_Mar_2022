﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal;
        
        private void button1_Click(object sender, EventArgs e)
        {
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox2.Text);
            if (radioButton1.Checked)
            {
               bal = bal + amt;
            }
            else if (radioButton2.Checked)
            {
                 bal = bal - amt;
            }
            label3.Text = "bal is " + bal;

        }
    }
}
