using System;
using System.Collections.Generic;

namespace CommerceProject.Model
{
    public class Cart
    {
        public decimal TotalAmount { get; set; }
        public List<OrderItem> Items { get; set; }

        public string CustomerEmail { get; set; }

        public Cart()
        {
            Items = new List<OrderItem>();
        }
    }

    public class OrderItem
    {
        public string Sku { get; set; }
        public int Quantity { get; set; }
    }
}