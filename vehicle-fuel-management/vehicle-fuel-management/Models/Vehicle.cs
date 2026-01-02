namespace NinthConsoleApp.Models
{
    internal class Car
    {
        public int InitialFuel { get; set; }
        public int Fuel { get; set; }

        public Car() { }

        public Car(int InitialFuel)
        {
            this.InitialFuel = InitialFuel;
            this.Fuel = InitialFuel;
        }

        

        public void Drive()
        {
            if (Fuel > 0)
            {
                Console.WriteLine("Car is driving");
            }

            else
            {
                Console.WriteLine("Car stopped, no fuel!");
            }
        }

        public int Refuel(int FuelAmount)
        {
            if (FuelAmount > 0)
            {
                Fuel += FuelAmount;
                Console.WriteLine($"Refueled with {FuelAmount}, current fuel is {Fuel}");
            }

            else
            {
                Console.WriteLine("Invalid! Amount should be positive!");
            }
            return Fuel;
        }
    }
}
