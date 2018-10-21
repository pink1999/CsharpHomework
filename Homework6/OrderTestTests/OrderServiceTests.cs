using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        static Customer cust1 = new Customer("Lily", "1678898098");
        static Good apple = new Good("apple", 2.5);
        OrderDetails detail1 = new OrderDetails(1, apple, 10000);
        Order order1 = new Order(1, cust1);
        OrderService service1 = new OrderService();
        Dictionary<uint, Order> dic1 = new Dictionary<uint, Order>();
        List<Order> list = new List<Order>();
        [TestMethod()]
        public void ExportTest()
        {
            list = null;
            service1.Export(list);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            service1.AddOrder(order1);
            dic1.Add(1, order1);
            CollectionAssert.AreEqual(service1.orderDict, dic1);

        }

        [TestMethod()]
        public void RemoveOrderTest()
        {
            service1.RemoveOrder(1);
            dic1.Remove(1);
            CollectionAssert.AreEqual(service1.orderDict, dic1);
        }

        [TestMethod()]
        public void SearchByCustomerNameTest()
        {
            service1.SearchByCustomerName("MARK");
            CollectionAssert.AreEqual(service1.SearchByCustomerName("MARK"), list);
        }

        [TestMethod()]
        public void SearchByGoodsTest()
        {
            order1.AddDetail(detail1);
            dic1.Add(1, order1);
            CollectionAssert.AreEqual(service1.SearchByGoods("apple"), list);
        }

        [TestMethod()]
        public void SerchOver10000Test()
        {

            CollectionAssert.AreEqual(service1.SerchOver10000(), list);
        }

        [TestMethod()]
        public void DisplayTest()
        {
            list = null;
            service1.Display(list);
        }

        [TestMethod()]
        public void InportTest()
        {
            CollectionAssert.AreEqual(service1.Inport("F://ssss.xml"),null);
        }
    }
}