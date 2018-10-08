using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order
{
    public class OrderDetails
    {
        string goods;
        int quantity;
        double price;
        public OrderDetails(string goods, int quantity, double price)
        {
            this.goods = goods;
            this.quantity = quantity;
            this.price = price;
        }
        public static void DispOrderDetails(List<OrderDetails> A)
        {
            foreach (OrderDetails a in A)
            {
                Console.WriteLine("商品名："+a.goods+",数量："+a.quantity+"，价格："+a.price);

            }
        }

    }
}
