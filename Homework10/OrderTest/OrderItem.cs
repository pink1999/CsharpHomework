using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace OrderTest
{
    public class OrderItem
    {
        [Key]
        public string Id { get; set; }
        public string Product { get; set; }
        public double UnitPrice { get; set; }
        public int Quantity { get; set; }

        public OrderItem()
        {
            Id = Guid.NewGuid().ToString();
        }

        public OrderItem(string id, string product, double unitPrice, int quantity)
        {
            Id = id;
            Product = product;
            UnitPrice = unitPrice;
            Quantity = quantity;
        }
    }
}
