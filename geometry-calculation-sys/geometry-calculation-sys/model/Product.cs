namespace TenthConsoleApp.model
{
    internal abstract class Product
    {
        public string Name { get; init; }
        public decimal Price { get; set; }
        public uint Quantity { get; set; }
        public string Description { get; set; }

        public Product() {

        }

        public Product(string name, decimal price, uint quantity, string description)

        {
            this.Name = name;
            this.Price = price;
            this.Quantity = quantity;
            this.Description = description;
        }


        public override string ToString() {
            return 
                $"\n{this.Name}" +
                $"\nPrice: {this.Price}" +
                $"\nQuantity: {this.Quantity}" +
                $"\nDescription: {this.Description}";
        }

        public virtual void Payment()
        {
            Console.WriteLine("This is a product class");
        }

        public abstract void Example();

    }
}
