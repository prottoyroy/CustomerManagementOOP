using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Product
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductInd = productId;
        }
        
        
        public decimal? CurrentPrice { get; set; }
        public int ProductInd { get; private set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public bool Save()
        {
            return true;
        }
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public Product Retrieve(int productId)
        {
            return new Product();
        }public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;
            return isValid;
        }
    }
}
