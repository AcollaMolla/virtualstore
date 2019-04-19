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

        public void updateQty(int id, int qty)
        {
            foreach(Product p in products)
            {
                if(p.ID == id)
                    p.QTY += qty;
            }
        }

        public bool productAlreadyExist(int id) //Consider making this return a int. 0=product already exist. 1=product don't exist. 2=product with same name exist, give user a warning
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

        public void addTestProduct()
        {
            addProduct("Test_product", 0, 100, 5);
        }

        public void decrementProduct(int id)
        {
            foreach(Product p in products){
                if (p.ID == id && p.QTY > 0)
                    p.QTY--;
            }
        }

        public bool isQtyZero(int id)
        {
            foreach (Product p in products)
            {
                if (p.ID == id && p.QTY <= 0)
                return true;
            }
            return false;
        }

        public void removeProduct(int id)
        {
            var itemToRemove = products.Single(r => r.ID == id);
            products.Remove(itemToRemove);
        }

        public void setProductsList(List<Product> list)
        {
            products = list;
        }
    }
}
