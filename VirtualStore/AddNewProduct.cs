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
    public partial class AddNewProduct : Form
    {
        Product product;
        private string name;
        private int productID;
        DatabaseHandler databaseHandler;
        public AddNewProduct()
        {
            InitializeComponent();
            product = new Product();
            databaseHandler = new DatabaseHandler();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.name = textBox1.Text;
            this.productID = Convert.ToInt32(textBox2.Text);
            product.setName(this.name);
            product.setId(this.productID);
            databaseHandler.writeToCSV();
        }
    }
}
