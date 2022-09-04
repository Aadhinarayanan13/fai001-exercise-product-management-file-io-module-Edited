using Repositories;
using System;

namespace ProductModuleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * code here is not mandatory but will help 
             * to understand flow better
             */

            List<Product> products = new List<Product>
            {
                new Product() { ProductId=1001,ProductName = "T-shirts",ProductPrice=1000,ProductQuantity = 19},
                new Product() { ProductId=2001,ProductName = "Shirts",ProductPrice=4000,ProductQuantity = 3},
                new Product() { ProductId=3001,ProductName = "Jeans",ProductPrice=8000,ProductQuantity = 8},
                new Product() { ProductId=4001,ProductName = "Cotton-PAnts",ProductPrice=6000,ProductQuantity = 4},
            };

            /* File Serializer */
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Product>));
            XmlSerializer xml = xmlSerializer;
            Stream stream = new FileStream(@"C:\Assignment\Stocks.xml",
                                      FileMode.OpenOrCreate);

            xml.Serialize(stream, products);


            Product detail = new Product();
            detail.AddProduct(detail);
            detail.RemoveProduct(detail);
            detail.GetAllProducts(detail);
        }
    }
}
