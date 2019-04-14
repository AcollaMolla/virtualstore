using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualStore
{
    class Cart
    {
        private static List<Product> products = new List<Product>();

        public void addProduct(string name, int id, float price, int amount)
        {
            if (!productAlreadyExist(id))
            {
                products.Add(new Product(name, id, price, amount));
                Console.WriteLine("Product added to cart");
            }
            else
                incrementAmount(id);
        }

        private bool productAlreadyExist(int id)
        {
            if (products == null)
                return false;
            foreach (Product p in products)
            {
                if (p.ID == id)
                    return true;
            }
            return false;
        }

        private void incrementAmount(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id)
                {
                    p.QTY++;
                }
            }
        }

        public List<Product> getAllProducts()
        {
            return products;
        }
    }
}
