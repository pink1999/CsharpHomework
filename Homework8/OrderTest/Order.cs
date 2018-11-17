using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace OrderTest
{
    public class Order
    {
        //  （1）订单号不能为空、不能重复、并且是”年月日+三位流水号”的形式。
        //   判断订单号是否重复在AddOrder中已给出
        private List<OrderDetails> details = new List<OrderDetails>();
        public Order(uint orderId, Customer customer)
        {
            Regex idRegex = new Regex(@"^\d{4}[0-1]\d[0-3]\d$");   
            if (idRegex.IsMatch(orderId.ToString()) == true) 
            {
                Id = orderId;
                Customer = customer;
            }
            else
            {
                Console.WriteLine("订单号无效！");
            }
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
