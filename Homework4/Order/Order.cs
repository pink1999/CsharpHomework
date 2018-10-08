using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Order
    {
        public string orderID, client;
        public static List<OrderDetails> orderDetails;
       
        public Order(string orderID,string client)
        {
            this.orderID = orderID;
            this.client = client;
        }
        public static void AddDetail(OrderDetails A)
        {
            orderDetails.Add(A);
        }
        public static void DeleteDetail(OrderDetails A)
        {
            orderDetails.Remove(A);
        }
       
    }
}
