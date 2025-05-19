using System;

namespace OOP_principles
{
    internal class Product
    {
        private string name;
        private Money price;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва продукту не може бути пустою");
                name = value;
            }
        }

        public Money Price
        {
            get { return price; }
            set
            {
                if (value == null)
                    throw new ArgumentNullException("Ціна не може бути null");
                price = value;
            }
        }

        public Product(string name, Money price)
        {
            Name = name;
            Price = price;
        }

        public void Display()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.Write("Ціна: ");
            Price.Display();
        }

        public void ReducePrice(Money amount)
        {
            Price.Subtract(amount);
        }
    }
}