using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.ass_order_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Order or = new Order();
            or.orno = Convert.ToInt32(textBox1.Text);
            or.cosname = textBox2.Text;
            or.pro = textBox3.Text;
            label6.Text = "Order Number : "+or.orno.ToString();
            label7.Text = "Customer Name : "+or.cosname.ToString();
            label8.Text = "Product Name : "+or.pro.ToString();
            float total = or.calculatetotalamount(Convert.ToSingle(textBox4.Text),Convert.ToInt32(textBox5.Text));
            label9.Text ="Total Amount : " +total.ToString();
        }
    }
}
