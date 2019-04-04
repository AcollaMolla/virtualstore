using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualStore
{
    public partial class Form1 : Form
    {
        AddNewProduct addNewProduct = new AddNewProduct();
        Cart cart = new Cart();
        Stack<int> productId = new Stack<int>();
        Stack<int> qty = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewProduct.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cart.addProduct(Int32.Parse(textBox1.Text), Decimal.ToInt32(numericUpDown1.Value));
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(productId != cart.getProductId()) //Only perform this if the cart has been changed
            {
                productId = cart.getProductId();
                foreach (int i in productId)
                {
                    richTextBox1.AppendText(i.ToString() + "\n");
                }
                qty = cart.getQty();
                foreach (int i in qty)
                {
                    richTextBox2.AppendText(i.ToString() + "\n");
                }
            }
        }
    }
}
