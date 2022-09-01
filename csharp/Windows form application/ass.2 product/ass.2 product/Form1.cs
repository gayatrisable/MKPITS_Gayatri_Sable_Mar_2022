using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;

namespace ass._2_product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ArrayList al = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            Product p1 = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Product p2 = new Product(Convert.ToInt32(textBox3.Text), textBox4.Text);
            al.Add(p1);
            al.Add(p2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product p in al)
            {
                sb.Append("Product Ref.no :" + p.prorefno + "    Product Name : " + p.name + "\n");
            }
            label5.Text = sb.ToString();

        }
    }
}
