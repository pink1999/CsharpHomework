using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //初始化订单A
            Order A = new Order("0501", "Mary");
            //初始化订单A 的条目
            OrderDetails A1 = new OrderDetails("milk",2000,3);
            OrderDetails A2 = new OrderDetails("apple", 3000, 2);
            //初始化订单BCDE
            Order B = new Order("0502", "Mark");
            Order C = new Order("0503", "Kavin");
            Order D = new Order("0504", "Lily");
            Order E = new Order("0505", "Suki");
            OrderService.OrderList = new List<Order>();
            OrderService.AddOrder(A);
            OrderService.AddOrder(B);
            OrderService.AddOrder(C);
            OrderService.AddOrder(D);
            OrderService.AddOrder(E);
            //打印订单信息
            OrderService.DispOrder(OrderService.OrderList);
            //删除订单C
            OrderService.DeleteOrder(C);
            //打印删除C后的订单
            OrderService.DispOrder(OrderService.OrderList);
            //修改订单B的信息
            OrderService.ChangeOrder(B,new Order("0506","Jack"));
            //打印修改后的订单
            OrderService.DispOrder(OrderService.OrderList);
            //查找客户Suki的订单
            OrderService.CheckOrder("Suki", OrderService.OrderList);
            //演示查找不到的情况
            OrderService.CheckOrder("Suk", OrderService.OrderList);
            Order.orderDetails= new List<OrderDetails>();
            Order.AddDetail(A1);
            Order.AddDetail(A2);
            //打印A订单的具体条目
            OrderDetails.DispOrderDetails(Order.orderDetails);
            Console.ReadKey();
        }
    }
}
