using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        public List<Order> Retrieve()
        {
            return new List<Order>();
        }
        public Order Retrieve(int orderId)
        {
            var order = new Order(orderId);
            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2020, 9, 29, 8, 6, 32,
                                 new TimeSpan(1, 0, 0));
            }
            return order;
        }
    }
}
