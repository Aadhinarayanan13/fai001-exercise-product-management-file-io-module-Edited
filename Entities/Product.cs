using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    /*
     * this serializable class models product data that includes product id, product name, price and in-stock status
     */

    public class Product
    {
        public int PdId { get; set; }
       
        public string PdName { get; set; }

        public int PdCost { get; set; }

        public bool PdAvailability { get; set; } 

        /*
         * define properties for Product model attributes 
         */


        /*
         * Override ToString() method to return string equivalent of product object containing product details
         */
        public override string ToString()
        {
            return $"ProductID : {PdId} ProductName: {PdName} ProductCost: {PdCost} ProductAvailability: {PdAvailability}";
        }
    }
}
