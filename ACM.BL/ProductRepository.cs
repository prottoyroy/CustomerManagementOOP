using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class ProductRepository
    {
        public List<Product> Retrieve()
        {
            return new List<Product>();
        }
        public Product Retrieve(int productId)
        {

            var product = new Product(productId);
            if (productId == 1)
            {
                product.ProductName = "sunFlowers";
                product.CurrentPrice = 15.9M;
                product.ProductDescription = "someThing";
            }
            return product;
        }
    }
}
