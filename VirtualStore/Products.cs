using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualStore
{
    class Products
    {
        private Product product = new Product();
        private static List<Product> products = new List<Product>();

        public Products()
        {
        }

        public void addProduct(string name, int id, float price, int qty)
        {
            if (!productAlreadyExist(id))
            {
                products.Add(new Product(name, id, price, qty));
                Console.WriteLine("Added to list");
            }
            else
            {
                foreach (Product p in products)
                {
                    if (p.ID == id)
                        p.QTY += qty;
                }
            }
        }

        public List<Product> getAllProducts()
        {
            return products;
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

        public void decrementProduct(int id)
        {
            foreach(Product p in products){
                if (p.ID == id && p.QTY > 0)
                    p.QTY--;
            }
        }
    }
}
