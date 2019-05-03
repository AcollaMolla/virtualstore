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
            int id;
            decimal price;
            string text;
            int qty;
            text = textBox2.Text.Replace('.', ',');
            if (!int.TryParse(textBox3.Text, out id))
            {
                MessageBox.Show("'Product ID' must be a numerical value (0-999999)!");
                return;
            }
            else if (!decimal.TryParse(text, NumberStyles.Any, CultureInfo.InvariantCulture, out price))
            {
                MessageBox.Show("'Product price' must be a numerical value!");
                return;
            }
            else if(!int.TryParse(textBox4.Text, out qty)){
                MessageBox.Show("'Product quantity' must be a numerical value (0-999999)!");
                return;
            }
            else if (products.productAlreadyExist(Convert.ToInt32(textBox3.Text)))
            {
                MessageBox.Show("Product ID already exist! Choose another!");
                return;
            }
            products.addProduct(textBox1.Text, Convert.ToInt32(textBox3.Text), textBox2.Text, Convert.ToInt32(textBox4.Text));
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            Hide();
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddNewProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
    }
}
