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
            OrderService orderService = new OrderService();
            //orderService.Delete("001");

            List<OrderItem> items = new List<OrderItem>() {
                new OrderItem("1", "milk", 1.9, 90),
                new OrderItem("2", "egg", 2.9, 55)
            };

            Order order = new Order("001", "Li", DateTime.Now, items);

            orderService.Add(order);

            Order order2 = new Order("001", "Jay", DateTime.Now, items);
            orderService.Update(order2);


            List<Order> orders = orderService.QueryByCustormer("Jay");
            orders.ForEach(
              o => Console.WriteLine($"{o.Id},{o.Customer}"));
        }
    }
}
