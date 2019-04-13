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
        private string name;
        private int productID;
        DatabaseHandler databaseHandler;
        private Product product = new Product();
        private List<Product> products = new List<Product>();
        public AddNewProduct()
        {
            InitializeComponent();
            databaseHandler = new DatabaseHandler();
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
            addProduct(textBox1.Text, Convert.ToInt32(textBox3.Text), float.Parse(textBox2.Text, CultureInfo.InvariantCulture.NumberFormat), Convert.ToInt32(textBox4.Text));
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void addProduct(string name, int id, float price, int qty)
        {
            if (!productAlreadyExist(id)) this.products.Add(new Product(name, id, price, qty));
        }

        public List<Product> getAllProducts()
        {
            return this.products;
        }

        private bool productAlreadyExist(int id) //Consider making this return a int. 0=product already exist. 1=product don't exist. 2=product with same name exist, give user a warning
        {
            if (products == null)
                return false;
            foreach (Product p in products)
            {
                if (p.ID == id)
                    return true;
                else
                    return false;
            }
            return false;
        }
    }
}
