﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checked_list_box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                sb.Append(checkedListBox1.CheckedItems[i] + "\n");
            }
            label1.Text = " Courses \n"+sb.ToString();
        }
    }
}
