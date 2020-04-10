using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Globalization;
namespace Produtos.Entities
{
    class OrderItem
    {
        public int Quantiy { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }
        public OrderItem(int quantiy, double price, Product produto)
        {
            Quantiy = quantiy;
            Price = price;
            Product = produto;
        }
        public double Subtotal()
        {
            return Price * Quantiy;
        }
        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantiy: "
                + Quantiy
                + ", Subtotal: $"
                + Subtotal().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}
    