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
    public partial class AddDelivery : Form
    {
        Products products;
        int id;
        public AddDelivery(int id)
        {
            InitializeComponent();
            products = new Products();
            this.id = id;
        }

        private void AddDelivery_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            products.updateQty(id, Convert.ToInt32(Math.Round(numericUpDown1.Value, 0)));
            Hide();
        }
    }
}
