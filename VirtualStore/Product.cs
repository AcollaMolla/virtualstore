using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualStore
{
    public class Product
    {
        private string name;
        private int id;
        private float price;
        private int qty;

        private List<Product> products = new List<Product>();

        public Product(string name, int id, float price, int qty)
        {
            this.name = name;
            this.id = id;
            this.price = price;
            this.qty = qty;
        }

        public Product()
        {

        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public int QTY
        {
            get
            {
                return qty;
            }
            set
            {
                qty = value;
            }
        }


    }
}
