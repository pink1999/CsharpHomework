using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;

namespace OrderTest
{   //在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；
    //添加一个Import方法可以从XML文件中载入订单。
    public class OrderService
    {
        
        public Dictionary<uint, Order> orderDict;
        //1）实现按照商品名称、客户等字段查询订单的功能;（2） 查询订单金额大于1万元的订单。
        public OrderService()
        {
            orderDict = new Dictionary<uint, Order>();
            
        }
        //将订单序列化为xml文件
        public void Export(List<Order> list)
        {
            StreamWriter sw = File.CreateText("D://s.xml");
            //xml序列化
            XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
            xmlser.Serialize(sw, list);
            sw.Flush();
            sw.Close();
        }
        //将一个xml文件反序列化
        public List<Order> Inport(string fileName)
        {
            if (File.Exists(fileName))
            {
                StreamReader sr = new StreamReader(fileName);
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                List<Order> orderList = xmlser.Deserialize(sr) as List<Order>;
                sr.Close();
                return orderList;
            }
            else
                return null;
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
            if (list == null) return;
            foreach(Order order in list)
            {
                Console.WriteLine(order.ToString());
                
            }
        }

    }
}
