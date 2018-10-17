using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    class OrderService
    {
        
        private Dictionary<uint, Order> orderDict;
        //1）实现按照商品名称、客户等字段查询订单的功能;（2） 查询订单金额大于1万元的订单。
        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
        }
        public void AddOrder(Order order)
        {
            if (orderDict.ContainsKey(order.Id))
                throw new Exception($"order-{order.Id} is already existed!");
            orderDict[order.Id] = order;
        }
        public void RemoveOrder(uint orderID)
        {
            orderDict.Remove(orderID);
        }
        public List<Order> SearchByCustomerName(string customerName)
        {
            var search = orderDict.Values
                .Where(order => order.Customer.Name == customerName);
            return search.ToList();
        }
        public List<Order> SearchByGoods(string goodsName)
        {
            List<Order> list = new List<Order>();
            foreach(Order order in orderDict.Values)
            {
                foreach(OrderDetails detail in order.Details)
                {
                    if(detail.Goods.Name==goodsName)
                        list.Add(order);
                    break;
                }

            }
            return list;
        }
        public List<Order> SerchOver10000()
        {
            List<Order> list = new List<Order>();
            foreach (Order order in orderDict.Values)
            {
                foreach (OrderDetails detail in order.Details)
                {
                    if ((detail.Quantity)*(detail.Goods.Price) > 10000)
                        list.Add(order);
                    break;
                }

            }
            return list;
        }
        public void Display(List<Order> list)
        {
            foreach(Order order in list)
            {
                Console.WriteLine(order.ToString());
                
            }
        }

    }
}
