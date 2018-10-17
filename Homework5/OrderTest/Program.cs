using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Customer cust1 = new Customer("Lily", "1678898098");
                Customer cust2 = new Customer("Jack", "1576668098");
                Customer cust3 = new Customer("Paul", "1899108098");
                Good apple = new Good("apple", 2.5);
                Good milk = new Good("milk", 3.5);
                Good banana = new Good("banana", 2);
                Good dress = new Good("dress", 99);
                Good shoes = new Good("shoes", 199);
                Order order1= new Order(1,cust1);
                Order order2 = new Order(2, cust2);
                Order order3 = new Order(3, cust3);
                OrderDetails detail1 = new OrderDetails(1, apple, 10000);
                OrderDetails detail2 = new OrderDetails(2, milk, 500);
                OrderDetails detail3 = new OrderDetails(3, banana, 200);
                OrderDetails detail4 = new OrderDetails(4, dress, 50);
                OrderDetails detail5 = new OrderDetails(5, shoes, 60);
                order1.AddDetail(detail1);
                order1.AddDetail(detail2);
                order2.AddDetail(detail3);
                order2.AddDetail(detail4);
                order3.AddDetail(detail5);
                OrderService service1 = new OrderService();
               
                service1.AddOrder(order1);
                service1.AddOrder(order2);
                service1.AddOrder(order3);
                service1.SearchByGoods("apple");
                List<Order> list = service1.SerchOver10000();
                service1.Display(list);
                list= service1.SearchByCustomerName("Lily");
                service1.Display(list);
                list = service1.SearchByGoods("dress");
                service1.Display(list);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
