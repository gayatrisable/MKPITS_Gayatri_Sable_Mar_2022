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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArrayList al = new ArrayList();
        Product[] pro = new Product[3];
        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i <= 3)
            {
                pro[i - 1] = new Product(Convert.ToInt32(textBox1.Text), textBox2.Text);
                al.Add(pro[i - 1]);
            }

            if (i == 3)
            {
                MessageBox.Show("3 Product added");
                button1.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Product p in al)
            {
                sb.Append("Product Ref.no :" + p.prorefno + "    Product Name : " + p.name + "\n");
            }
            label3.Text = sb.ToString();
        }

    }
}

