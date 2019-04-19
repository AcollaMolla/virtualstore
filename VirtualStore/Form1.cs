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
        AddNewProduct addNewProduct;
        AddDelivery addDelivery;
        Cart cart;
        private string[] row;
        private Products products;
        DatabaseHandler databaseHandler;
        private bool newData = false;
        public Form1()
        {
            InitializeComponent();
            addNewProduct = new AddNewProduct();
            cart = new Cart();
            row = new string[4];
            products = new Products();
            databaseHandler = new DatabaseHandler();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addNewProduct.ShowDialog();
            productListUpdated();
            newData = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //products.addTestProduct();
            products.setProductsList(databaseHandler.readFromCSV());
            productListUpdated();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems[0].Text != null || !listView1.SelectedItems[0].Text.Equals(""))
            {
                ListViewItem item = listView1.SelectedItems[0];
                cart.addProduct(item.SubItems[0].Text, Convert.ToInt32(item.SubItems[1].Text), float.Parse(item.SubItems[2].Text, NumberStyles.Any, (CultureInfo)CultureInfo.CurrentCulture.Clone()), 1, Convert.ToInt32(item.SubItems[3].Text));
                products.decrementProduct(Convert.ToInt32(item.SubItems[1].Text));
                productListUpdated();
                cartListUpdated();
                button1.Enabled = false;
                newData = true;
            }
            else
                button1.Enabled = false;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        public void productListUpdated()
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

            listView3.Items.Clear();
            foreach (Product p in products.getAllProducts())
            {
                row[0] = p.Name;
                row[1] = p.ID.ToString();
                row[2] = p.Price.ToString();
                row[3] = p.QTY.ToString();
                ListViewItem item = new ListViewItem(row);
                listView3.Items.Add(item);
            }
        }

        public void cartListUpdated()
        {
            listView2.Items.Clear();
            foreach (Product p in cart.getAllProducts())
            {
                row[0] = p.Name;
                row[1] = p.Price.ToString();
                row[2] = p.QTY.ToString();
                row[3] = p.ID.ToString();
                if (p.QTY > 0)
                {
                    ListViewItem item2 = new ListViewItem(row);
                    listView2.Items.Add(item2);
                }
            }
            button2.Enabled = false;
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ListViewItem item = listView2.SelectedItems[0];
            if(!cart.isQtyZero(Convert.ToInt32(item.SubItems[3].Text)))
                products.addProduct(item.SubItems[0].Text, Convert.ToInt32(item.SubItems[3].Text), float.Parse(item.SubItems[1].Text, CultureInfo.InvariantCulture.NumberFormat),1);
            cart.decrementProduct(Convert.ToInt32(item.SubItems[3].Text));
            productListUpdated();
            cartListUpdated();
            button1.Enabled = false;
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView2.SelectedItems[0].Text != null || !listView2.SelectedItems[0].Text.Equals(""))
                button2.Enabled = true;
        }

        private void removeProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("This action will permanently remove this product. Do you wan't to continue?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    ListViewItem item = listView3.SelectedItems[0];
                    products.removeProduct(Convert.ToInt32(item.SubItems[1].Text));
                    productListUpdated();
                    newData = true;
                }
                else if (dialogResult == DialogResult.No) { }
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Please select the product you wan't to remove!");
            }
        }

        private void addDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView3.SelectedItems[0];
                addDelivery = new AddDelivery(Convert.ToInt32(item.SubItems[1].Text));
                addDelivery.ShowDialog();
                productListUpdated();
                newData = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Please select the product you wan't to add delivery for!");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newData)
            {
                DialogResult dialogResult = MessageBox.Show("There is unsaved data. Save it now?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    databaseHandler.writeToCSV(products.getAllProducts());
                }
                else if (dialogResult == DialogResult.No) { }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            databaseHandler.writeToCSV(products.getAllProducts());
            newData = false;
        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.Out.WriteLine("changed");
            removeProductToolStripMenuItem.Enabled = true;
            addDeliveryToolStripMenuItem.Enabled = true;
        }
    }
}
