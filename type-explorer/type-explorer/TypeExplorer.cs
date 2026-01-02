namespace TwentyThirdConsoleApp
{
    internal class TypeExplorer
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Id { get; set; }
        public bool IsOnStock { get; set; }

        public void Explore(Type type)
        {

            Console.WriteLine("====================================");
            Console.WriteLine($"Type Name: {type.Name}");
            Console.WriteLine($"Namespace: {type.Namespace}");
            Console.WriteLine($"Base Type: {type.BaseType?.Name}");

            Console.WriteLine("\nImplemented Interfaces:");
            foreach (var i in type.GetInterfaces())
            {
                Console.WriteLine($"\t{i.Name}");
            }


            Console.WriteLine("\nProperties: ");
            foreach (var prop in type.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }
        }
    }
}
