using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirtualStore
{
    public partial class AddNewProduct : Form
    {
        private Products products;
        public AddNewProduct()
        {
            InitializeComponent();
            products = new Products();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            products.addProduct(textBox1.Text, Convert.ToInt32(textBox3.Text), float.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(textBox4.Text));
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
