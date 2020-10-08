using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        public OrderItem()
        {

        }
        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
        }
        public int OrderItemId { get; set; }
        public int OrderQuantity { get; private set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }
        public bool Save()
        {
            return true;
        }
        public List<OrderItem> Retrieve()
        {
            return new List<OrderItem>();
        }
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }
        public bool Validate()
        {
            var isValid = true;
            if (OrderQuantity <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice == null) isValid = false;
            return isValid;
        }



    }
    

}
