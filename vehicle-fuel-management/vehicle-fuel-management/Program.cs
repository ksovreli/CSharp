using NinthConsoleApp.Models;

Car car = new Car(0);

string input;
int fuelAmount;


while (true)
{
    Console.WriteLine("Enter amount of fuel to fill or type exit: ");
    input = Console.ReadLine() ?? string.Empty;

    if (string.Equals(input, "exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("You pressed exit");
        break;
    }


    fuelAmount = Convert.ToInt32(input);
    car.Refuel(fuelAmount);
    car.Drive();
}