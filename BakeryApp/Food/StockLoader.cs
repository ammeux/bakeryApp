using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using BakeryApp.Food;

namespace BakeryApp.Food
{
    class StockLoader
    {

        public void save(Stock stock, String fileName)
        {
            var doc = new XmlDocument();

            XmlSerializer xs = new XmlSerializer(typeof(Stock));
            TextWriter tw = new StreamWriter(fileName);
            xs.Serialize(tw, stock);
            tw.Close();
        }

        public Stock load()
        {
            Stock stock = new Stock();
            var directory = new DirectoryInfo(@"C:\Users\marco\OneDrive\Documents\Epitech\BakeryApp\BakeryApp\bin\Debug");
            var myFile = (from f in directory.GetFiles("*.xml")
                          orderby f.LastWriteTime descending
                          select f).First();
            var serializer = new XmlSerializer(typeof(Stock));
            using (var s = File.OpenRead(myFile.ToString()))
            {
                stock = (Stock)serializer.Deserialize(s);
            }
            return stock;
        }
    }
}
