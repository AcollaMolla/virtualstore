using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace VirtualStore
{
    class DatabaseHandler
    {
        private int id;
        private string name;
        public void writeToCSV(List<Product> list, string path)
        {
            using (var writer = new StreamWriter(path + "store.csv"))
            using (var csv = new CsvWriter(writer))
            {
                csv.WriteRecords(list);
            }
        }

        public List<Product> readFromCSV(string file)
        {
            try
            {
                using (var reader = new StreamReader(file))
                using (var csv = new CsvReader(reader))
                {
                    var records = csv.GetRecords<Product>();
                    return records.ToList();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("No file found" + e);
                return null;
            }
        }

        public void export(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
            File.Copy("store.csv", path); //Just copy the already saved inventory to the new directory
        }
    }
}
