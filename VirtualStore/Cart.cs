using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualStore
{
    class Cart
    {
        private int productId;
        private int qty = 0;
        Stack<int> testProductId = new Stack<int>();
        Stack<int> testQty = new Stack<int>();
       // Product product = new Product();

        public void addProduct(int id, int qty)
        {
            testProductId.Push(id);
            this.qty = this.qty + qty;
            testQty.Push(qty);
        }

        public Stack<int> getProductId()
        {
            return testProductId;
        }

        public Stack<int> getQty()
        {
            return testQty;
        }
    }
}
