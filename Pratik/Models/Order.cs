﻿namespace Pratik.Models
{
    public class Order
    {
        public int Id { get; set; }    // Siparişin benzersiz kimliği
        public string ProductName { get; set; }    // Ürün adı
        public decimal Price { get; set; }    // Ürün fiyatı
        public int Quantity { get; set; }    // Sipariş adedi
    }
}
