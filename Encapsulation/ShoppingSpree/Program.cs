using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();
            var productList = new List<Product>();

            try
            {
                string[] personInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);
                string[] productInput = Console.ReadLine().Split(';', StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < personInput.Length; i++)
                {
                    string[] parts = personInput[i].Split('=');
                    string name = parts[0];
                    decimal money = decimal.Parse(parts[1]);

                    var person = new Person(name, money);
                    personList.Add(person);
                }

                for (int i = 0; i < productInput.Length; i++)
                {
                    string[] parts = productInput[i].Split('=');
                    string name = parts[0];
                    decimal cost = decimal.Parse(parts[1]);

                    var product = new Product(name, cost);
                    productList.Add(product);
                }


                var sb = new StringBuilder();

                while (true)
                {
                    string[] command = Console.ReadLine().Split(' ');

                    if (command[0] == "END")
                    {
                        break;
                    }

                    string personName = command[0];
                    string productName = command[1];

                    var person = personList.FirstOrDefault(x => x.Name == personName);
                    var product = productList.FirstOrDefault(x => x.Name == productName);

                    if ((person.Money - product.Cost) >= 0)
                    {
                        sb.AppendLine($"{person.Name} bought {product.Name}");

                        person.Money -= product.Cost;
                        person.Bag.Add(product);

                        personList.Remove(person);
                        personList.Add(person);

                        productList.Remove(product);
                        productList.Add(product);
                    }
                    else
                    {
                        sb.AppendLine($"{person.Name} can't afford {product.Name}");
                    }
                }

                foreach (var person in personList)
                {
                    var productNames = new List<string>();
                    foreach (var product in person.Bag)
                    {
                        productNames.Add(product.Name);
                    }
                    string products = string.Join(", ", productNames);

                    if (person.Bag.Count == 0)
                    {
                        products = "Nothing bought";
                    }

                    sb.AppendLine($"{person.Name} - {products}");
                }

                Console.WriteLine(sb.ToString().Trim());
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
