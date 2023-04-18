
using PizzaMizza.App.Services.Implementations;
using PizzaMizza.App.Services.Interfaces;

IPizzaService pizzaService=new PizzaService();


Console.WriteLine("0. Close");
Console.WriteLine("1. Createpizza");
Console.WriteLine("2. Showpizzas");
Console.WriteLine("3. ShowpizzaById");
Console.WriteLine("4. UpdatepizzaById");
Console.WriteLine("5. DeletepizzaById");

string Request = Console.ReadLine().Trim();

while (Request != "0")
{

    switch (Request)
    {
        case "1":
            pizzaService.Create();
            break;
        case "2":
            pizzaService.ShowAll();
            break;
        case "3":
            pizzaService.ShowById();
            break;
        case "4":
            pizzaService.Update();
            break;

        case "5":
            pizzaService.Delete();
            break;
        default:
            Console.WriteLine("Chose valid option");
            break;
    }

    Console.WriteLine("0. Close");
    Console.WriteLine("1. Createpizza");
    Console.WriteLine("2. Showpizzas");
    Console.WriteLine("3. ShowpizzaById");
    Console.WriteLine("4. UpdatepizzaById");
    Console.WriteLine("5. DeletepizzaById");

    Request = Console.ReadLine();
}
