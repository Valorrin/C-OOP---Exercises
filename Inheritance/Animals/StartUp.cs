using System;
using System.Text;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var sb = new StringBuilder();

            while (true)
            {
                string animalType = Console.ReadLine();

                if (animalType == "Beast!")
                {
                    break;
                }

                string[] parts = Console.ReadLine().Split(' ');
                string name = parts[0];
                int age = int.Parse(parts[1]);
                string gender = parts[2];


                if (age < 0 || (gender != "Male" && gender != "Female"))
                {
                    sb.AppendLine("Invalid input!");
                    continue;
                }

                if (animalType == "Dog")
                {
                    var dog = new Dog(name, age, gender);
                    sb.AppendLine(dog.ToString());
                }
                else if (animalType == "Cat")
                {
                    var cat = new Cat(name, age, gender);
                    sb.AppendLine(cat.ToString());
                }
                else if (animalType == "Frog")
                {
                    var frog = new Frog(name, age, gender);
                    sb.AppendLine(frog.ToString());
                }
                else if (animalType == "Kitten")
                {
                    var kitten = new Kitten(name, age);
                    sb.AppendLine(kitten.ToString());
                }
                else if (animalType == "Tomcat")
                {
                    var tomcat = new Tomcat(name, age);
                    sb.AppendLine(tomcat.ToString());
                }

            }

            Console.WriteLine(sb.ToString());
        }
    }
}
