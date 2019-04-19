
using CsvHelper;
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
            using (var writer = new StreamWriter("store.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(list);
            }
        }

        public void readFromCSV()
        {
            //TODO
        }
    }
}
