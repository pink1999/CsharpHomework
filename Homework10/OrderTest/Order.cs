﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace OrderTest
{
    public class Order
    {
        [Key]
        public String Id { get; set; }
        public String Customer { get; set; }
        public DateTime CreateTime { get; set; }
        public List<OrderItem> Items { get; set; }

        public Order()
        {
            Items = new List<OrderItem>();
        }

        public Order(string id, string customer, DateTime createTime, List<OrderItem> items)
        {
            Id = id;
            Customer = customer;
            CreateTime = createTime;
            Items = items;
        }
    }
}
