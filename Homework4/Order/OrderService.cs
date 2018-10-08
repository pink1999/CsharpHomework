using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    static class OrderService
    {
        public static List<Order> OrderList;
        public static void AddOrder(Order A)
        {
            OrderList.Add(A);
        }
        public static void DeleteOrder(Order A)
        {
            if (OrderList.IndexOf(A) == -1)
            {
                Console.WriteLine("该订单不在此，无法删除！");
            }
            else
                OrderList.IndexOf(A);
        }
        public static void ChangeOrder(Order A,Order B)
        {
            int a = OrderList.IndexOf(A);
            OrderList[a] = B;
        }
        public static void CheckOrder(string x,List<Order> A)
        {
            bool flag = false;
            foreach (Order a in A)
            {
                if(string.Equals(a.orderID,x)|| string.Equals(a.client, x))
                {
                    Console.WriteLine("已找到该订单：" + a.orderID + " " + a.client);
                    flag = true;
                }
                
            }
            if(flag==false)
            {
                Console.WriteLine("找不到该订单！");
            }
        }
        public static void DispOrder(List<Order> A)
        {
            foreach (Order a in A)
            {
                Console.WriteLine("订单号："+a.orderID+"，客户："+a.client);
               
            }
        }
    }
}
