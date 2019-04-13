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
        Product p = new Product();
        private string[] row = new string[4];
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
            foreach(Product p in addNewProduct.getAllProducts())
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
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("test"); 
        }
    }
}
