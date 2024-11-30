// Product.cs
using System;

namespace OnlineStore
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }
        public string Description { get; }

        // Конструктор с параметрами
        public Product(string name, decimal price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        // Деконструктор
        public void Deconstruct(out string name, out decimal price, out string description)
        {
            name = Name;
            price = Price;
            description = Description;
        }
    }
}
