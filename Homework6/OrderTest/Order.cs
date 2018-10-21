using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    public class Order
    {
        private List<OrderDetails> details = new List<OrderDetails>();
        public Order(uint orderId, Customer customer)
        {
            Id = orderId;
            Customer = customer;
        }
        public Order()
        {
        }
        public List<OrderDetails> Details
        {
            get=>this.details;
        }
        public uint Id
        {
            get;set;
        }
        public Customer Customer
        {
            get; set;
        }
        public void AddDetail(OrderDetails detail)
        {
            if(this.details.Contains(detail))
                throw new Exception("orderDetails is already existed!");
            details.Add(detail);
        }
        public void RemoveDetails(uint orderDetailId)
        {
            details.RemoveAll(d => d.Id == orderDetailId);
        }
        public override string ToString()
        {
            string result = "================================================================================\n";
            result += $"订单号:{Id}, 客户:({Customer})";
            details.ForEach(od => result += "\n\t" + od);
            result += "\n================================================================================";
            return result;
        }
    }
}
