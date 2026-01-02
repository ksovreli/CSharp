using SeventhConsoleApp.Enums;

namespace SeventhConsoleApp
{
    internal class Car
    {
        private decimal _price;
        private DateTime _year;
        public string Model { get; init; }
        public DateTime Year {
            get
            {
                return _year;
            }

            init
            {
                if(value > DateTime.Now)
                {
                    Console.WriteLine("error");
                }

                else
                {
                    _year = value;
                }

               
            }
        }
        public decimal Price {
            get
            {
                return _price;
            }

            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Price cannot be negative!");
                }

                else
                {
                    _price = value;
                }
            }
        }
        public uint Quantity { get; set; }
        public string Country { get; init; }
        public CarBrand Brand { get; init; }
        public string Description { get; set; }


        public Car()
        {

        }

        public Car(string model, DateTime year, decimal price, uint quantity, string country, CarBrand brand, string description)
        {
            Model = model;
            Year = year;
            Price = price;
            Quantity = quantity;
            Country = country;
            Brand = brand;
            Description = description;
        }

        public void Print()
        {
            Console.WriteLine(
            $"\n\tModel: {Model}, " + 
            $"\n\tYear: {Year}, " +
            $"\n\tPrice: {Price}$, " +
            $"\n\tQuantity: {Quantity}, " +
            $"\n\tCountry: {Country}, " +
            $"\n\tBrand: {Brand}, " +
            $"\n\tDescription: {Description}");
        }
    }
}
