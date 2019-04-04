using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualStore
{
    class Product
    {
        private string name;
        private float price;
        private int id;
        private int qty;

        public string getName()
        {
            return this.name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public float getPrice()
        {
            return this.price;
        }

        public void setPrice(float price)
        {
            this.price = price;
        }

        public int getId()
        {
            return this.id;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public int getQty()
        {
            return this.qty;
        }

        public void setQty(int qty)
        {
            this.qty = qty; //Perhaps this.qty = this.qty + qty?
        }
    }
}
