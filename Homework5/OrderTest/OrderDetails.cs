using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTest
{
    class OrderDetails
    {
        
        public OrderDetails(uint id, Good goods, uint quantity)
        {
            Id = id;
            Goods = goods;
            Quantity = quantity;
        }

        public uint Id
        {
            get;set;
        }
        public Good Goods
        {
            get;set;
        }
        public uint Quantity
        {
            get; set;
        }

        public override string ToString()
        {
            return $"订单明细号：{Id} {Goods} 数量：{Quantity}";
        }
    }
}
