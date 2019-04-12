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
        public void writeToCSV()
        {
            List<string> mylist = new List<string>(new string[] { "element1", "element2", "element3" });
            using (var writer = new StreamWriter("file.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords("test");
            }
        }
    }
}
