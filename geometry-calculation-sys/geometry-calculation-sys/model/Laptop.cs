using TenthConsoleApp.enums;

namespace TenthConsoleApp.model
{
    internal class Laptop : Product
    {
        private string processor
        public Brands Brand { get; set; }
        public string Processor {
            get { return Processor; }
            set
            {
                if (value == "smth" || value == "something")
                {
                    processor = value;
                }

                else
                {
                    Console.WriteLine("Value is incorrect!");
                }
            }
        }
        public Ram RAM { get; set; }

        public Laptop()
        {
        }


        public Laptop(
            string name,
            decimal price,
            string description,
            uint quantity,
            Brands brand,
            string processor,
            Ram ram
        ) : base(name, price, quantity, description)
        {
            this.Brand = brand;
            this.Processor = processor;
            this.RAM = ram;
        }

        public override void Payment()
        {
            Console.WriteLine("This is a laptop class");
        }

        public override string ToString()
        {
            return
                $"\nName: \t {this.Name}" +
                $"\nPrice: \t {this.Price}$" +
                $"\nQuantity: \t {this.Quantity}" +
                $"\nDescription: \t {this.Description}" +
                $"\nBrand: \t {this.Brand}" +
                $"\nCPU: \t {this.Processor}" +
                $"\nRAM: \t {this.RAM}";
        }

        public override void Example()
        {
            Console.WriteLine("Laptop = example");
        }
    }
}
