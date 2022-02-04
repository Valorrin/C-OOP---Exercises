using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;

        public List<Product> Bag { get; set; }

        public string Name
        {
            get => name; 
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be null");
                }
            }
        }
        public decimal Money
        {
            get => money;
            set
            {
                if (value >= 0)
                {
                    this.money = value;
                }
                else
                {
                    throw new ArgumentException("Money cannot be negative");
                }
            }
        }
        public Person(string name, decimal money)
        {
            this.Name = name;
            this.Money = money;
            Bag = new List<Product>();
        }
    }
}
