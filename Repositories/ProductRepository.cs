using Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public class ProductRepository
    {
        // declare field of type DataContext

        public DataContext context = null;
      
        List<Product> products = new List<Product>();

        public ProductRepository(string filename, string path)
        {
            DataContext context = new DataContext(filename, path);
            //initialize the DataContext field with parameter passed    
        }

        public ProductRepository(DataContext context)
        {
            this.context = context;
        }





        /*
         * this method should accept product data and add it to the product collection
         * 
         */
        public void AddProduct(Product product)
        {
            products.Add(product);

        }


        /*
         * this method should search for the product by the provided product id 
         * and if found should remove it from the collection
         * 
         * the method should return true for success and false for invalid id 
         */
        public bool RemoveProduct(int productID)
        {
            List<Product> products = GetAllProducts();
            Product product = new Product();
             
           
                foreach (Product p in products)
                {

                if(p.PdId==productID)
                {
                    product.PdId = p.PdId;
                    product.PdName = p.PdName;
                    product.PdCost = p.PdCost;
                    product.PdAvailability = p.PdAvailability;
                    products.Remove(product);
                    return true;
                }
                   
                }
            
                return false;
          
            // code to remove product by the id provided from file as parameter    
        }

        /*
         * this method should search and return product by product name from the file 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product name
         */
        public Product GetProduct(string productName)
        {
            List<Product> products = GetAllProducts();
            Product product = new Product();
            if (products.Count > 0)
            {
                foreach (Product p in products)
                {
                    if (p.PdName == productName)
                    {
                        product.PdId = p.PdId;
                        product.PdName = p.PdName;
                        product.PdCost = p.PdCost;
                        product.PdAvailability = p.PdAvailability;
                    }
                }

                return product;
            }
            else
                return null;



        }

        /*
         * this method should search and return product by product id from the collection 
         * 
         * the search value should be passed as parameter
         * 
         * the method should return null for non-matching product id
         */
        public Product GetProduct(int productId)
        {
            List<Product> products = GetAllProducts();
            Product product = new Product();
            if (products.Count > 0)
            {
                foreach (Product p in products)
                {
                    if (p.PdId == productId)
                    {
                        product.PdId = p.PdId;
                        product.PdName = p.PdName;
                        product.PdCost = p.PdCost;
                        product.PdAvailability = p.PdAvailability;
                    }
                }

                return product;
            }
            else
                return null;
        }


        /*
         * this method should return all items from the product collection
         */
        public List<Product> GetAllProducts()
        {

            return context.ReadProducts();

        }
    }
}
