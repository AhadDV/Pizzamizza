

using PizzaMizza.App.Services.Interfaces;
using PizzaMizza.Core.Enums;
using PizzaMizza.Core.Models;
using System.Linq.Expressions;

namespace PizzaMizza.App.Services.Implementations
{
    public class PizzaService : IPizzaService
    {
        private Pizza[] Pizzas = new Pizza[0];

        public void Create()
        {
            Console.WriteLine("Add Name");
            string name = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Add valid name");
                name = Console.ReadLine();
            }

            Console.WriteLine("Add Price");

            double.TryParse(Console.ReadLine(), out double Price);

            while (Price <= 0)
            {
                Console.WriteLine("Add valid price");
                double.TryParse(Console.ReadLine(), out Price);
            }

        againchoose:
            Console.WriteLine("Choose size");

            Console.WriteLine("1." + " " + PizzaSize.Small);
            Console.WriteLine("2." + " " + PizzaSize.Medium);
            Console.WriteLine("3." + " " + PizzaSize.Large);

            string result = Console.ReadLine();
            PizzaSize size;
            switch (result)
            {
                case "1":
                    size = PizzaSize.Small;
                    break;
                case "2":
                    size = PizzaSize.Medium;
                    break;
                case "3":
                    size = PizzaSize.Large;
                    break;

                default:
                    Console.WriteLine("invalid option");
                    goto againchoose;
            }

            Pizza pizza = new Pizza
            {
                Name = name,
                Price = Price,
                CreatedDate = DateTime.Now,
                Size = size,
            };

            Array.Resize(ref Pizzas, Pizzas.Length + 1);

            Pizzas[Pizzas.Length - 1] = pizza;
        }

        public void Delete()
        {
            Console.WriteLine("Enter id");

            int.TryParse(Console.ReadLine(), out int Id);

            for (int i = 0; i < Pizzas.Length; i++)
            {
                if (Pizzas[i].Id == Id)
                {

                    Pizzas[i] = Pizzas[Pizzas.Length - 1];

                    Array.Resize(ref Pizzas, Pizzas.Length - 1);
                    Console.WriteLine("Deleted");
                    return;
                }
            }

            Console.WriteLine("Pizza not found");
        }

        public void ShowAll()
        {
            foreach (var item in Pizzas)
            {
                Console.WriteLine(item);
            }
        }

        public void ShowById()
        {

            Console.WriteLine("Enter id");

            int.TryParse(Console.ReadLine(), out int Id);

            for (int i = 0; i < Pizzas.Length; i++)
            {
                if (Pizzas[i].Id == Id)
                {
                    Console.WriteLine(Pizzas[i]);
                    return;
                }
            }

            Console.WriteLine("Pizza not found");

        }

        public void Update()
        {

            Console.WriteLine("Enter id");

            int.TryParse(Console.ReadLine(), out int Id);

            for (int i = 0; i < Pizzas.Length; i++)
            {
                if (Pizzas[i].Id == Id)
                {
                    Console.WriteLine("add name");
                    string name = Console.ReadLine();

                    while (string.IsNullOrWhiteSpace(name))
                    {
                        Console.WriteLine("add name");

                        name = Console.ReadLine();
                    }
                    Pizzas[i].Name = name;
                    Pizzas[i].UpdatedDate = DateTime.Now;
                    return;
                }
            }

            Console.WriteLine("Pizza not found");

        }
    }
}
