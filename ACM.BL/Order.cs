using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }
        public Order(int orderId)
        {
            this.OrderId = orderId;
        }
        
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }
        public bool Save()
        {
            return true;
        }
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public Order Retrieve(int orderId)
        {
            return new Order();
        }
        public bool Validate()
        {
            var isValid = true;
            if (OrderDate == null) isValid = false;
            return isValid;
        }

    }
}
