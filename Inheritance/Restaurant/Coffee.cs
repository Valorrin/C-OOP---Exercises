using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, decimal price, double milliliters)
            :base(name, price, milliliters)
        {

        }

        public double CoffeeMilliliters => 50;

        public decimal CoffeePrice => (decimal)3.50;

        public double Caffeine { get; set; }
    }
}
