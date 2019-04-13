
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualStore
{
    class DatabaseHandler
    {
        private int id;
        private string name;
        public void writeToCSV(List<Product> list)
        {
            foreach(Product p in list)
            {
                Console.Out.WriteLine(p.Name);
                Console.Out.WriteLine(p.ID);
                Console.Out.WriteLine(p.Price);
                Console.Out.WriteLine(p.QTY);
            }
        }
    }
}
