﻿namespace Merchant.Models
{
    public class OrderItem
    {
        public int Id { get; set; } 
        public virtual Product Product { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
    }
}