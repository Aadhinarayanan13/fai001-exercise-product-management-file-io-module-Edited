using Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Serialization;

namespace Repositories
{
    // this class provides functionalities to read and write product collection data with file

    public class DataContext
    {
        // declare field for filename with path
        // declare field for list of products

        public string fileName = "Products.xml";
        public string path = @"C:\Assignment\Stocks.xml";
         List<Product> products = new List<Product>();
   
        // the constructor should accept filename and path strings
        public DataContext(string fileName, string path)
        {
            // the constructor code should open file if it exists else create new

            // the code should read data from file if it contains any data

            // the data read should populate the list of products field

            // if no data is present an empty list should be created 

            if(!File.Exists(path))
            {
                File.Create(path);
                Console.WriteLine("File created");
                List<Product> products = new List<Product>();

            }
            else
            {
                Console.WriteLine("File already exists");

                var content = File.ReadAllLines(path);
             if(content==null)
                {
                    List<Product> products = new List<Product>();
                }
              
                }
            
            
        }

        // this method should return the list of products read from file
        public string ReadProducts(Product products)
        {
            // return data of the product list
            StreamReader contentReader = new StreamReader(path);
            var contents = contentReader.ReadToEnd();
            return contents;

        }

        // this method should add the product data passed as parameter to the list of products
        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        // this method should write the data from list of products to file and make data persistent
        public void SaveChanges()
        {
            // implement serialization
            XmlSerializer xml = new XmlSerializer(typeof(List<Product>));
            Stream stream = new FileStream(path, FileMode.OpenOrCreate);

            xml.Serialize(stream, products);

        }

        // this method should delete the file if exists
        public void CleanUp()
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                Console.WriteLine("File deleted");
            }
            }

        internal List<Product> ReadProducts()
        {
            throw new NotImplementedException();
        }
    }
}



