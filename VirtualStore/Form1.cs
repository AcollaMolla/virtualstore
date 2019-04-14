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
    public partial class Form1 : Form
    {
        AddNewProduct addNewProduct = new AddNewProduct();
        Cart cart = new Cart();
        Stack<int> productId = new Stack<int>();
        Stack<int> qty = new Stack<int>();
        Product p = new Product();
        private string[] row = new string[4];
        private Products products = new Products();
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

        private void button2_Click_1(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button3_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach(Product p in products.getAllProducts())
            {
                row[0] = p.Name;
                row[1] = p.ID.ToString();
                row[2] = p.Price.ToString();
                row[3] = p.QTY.ToString();
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToCartButton.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListViewItem item = listView1.SelectedItems[0];
            Console.WriteLine(item.SubItems[0].Text);
            cart.addProduct(item.SubItems[0].Text, Convert.ToInt32(item.SubItems[1].Text), float.Parse(item.SubItems[2].Text, CultureInfo.InvariantCulture.NumberFormat), 1);
            products.decrementProduct(Convert.ToInt32(item.SubItems[1].Text));
            listUpdated();
            listView2.Items.Clear();
            foreach (Product p in cart.getAllProducts())
            {
                row[0] = p.Name;
                row[1] = p.Price.ToString();
                row[2] = p.QTY.ToString();
                ListViewItem item2 = new ListViewItem(row);
                listView2.Items.Add(item2);
            }
            addToCartButton.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addToCartButton.Enabled = true;
        }

        public void listUpdated()
        {
            listView1.Items.Clear();
            foreach (Product p in products.getAllProducts())
            {
                row[0] = p.Name;
                row[1] = p.ID.ToString();
                row[2] = p.Price.ToString();
                row[3] = p.QTY.ToString();
                ListViewItem item = new ListViewItem(row);
                listView1.Items.Add(item);
            }
        }
    }
}
