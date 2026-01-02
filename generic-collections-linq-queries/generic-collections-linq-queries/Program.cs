//using NineteenthConsoleApp.models;

//List<Orders> orders = new List<Orders>
//{
//    new Orders { PersonId = 1, Product = "Laptop" },
//    new Orders { PersonId = 2, Product = "Phone" },
//    new Orders { PersonId = 3, Product = "Headphones" }
//};

//List<Person> people = new List<Person>
//{
//    new Person { Id = 1, Name = "Giorgi", Age = 18 },
//    new Person { Id = 2, Name = "Nino", Age = 15 },
//    new Person { Id = 3, Name = "Sandro", Age = 23 }
//};
//static void Print<T>(IEnumerable<T> collection)
//{
//    foreach (T i in collection)
//    {
//        Console.WriteLine(i);
//    }
//}


//var query = from order in orders
//            join person in people on order.PersonId equals person.Id
//            select new
//            {
//                ProductName = person.Name,
//                OrderProduct = order.Product,
//                PersonAge = person.Age
//            };

//var printGiorgi = query.Where(item => item.ProductName == "Giorgi");
//Print(printGiorgi);

//Console.WriteLine("========================");

//Print(query);

//Console.WriteLine("========================");

//var printAdults = query.Where(a => a.PersonAge >= 18);
//Print(printAdults);

//Console.WriteLine("========================");

//var sortByAge = query.OrderBy(a => a.PersonAge);
//Print(sortByAge);

//Console.WriteLine("========================");

//var printOnlyNames = query.Select(a => a.ProductName);
//Print(printOnlyNames);



List<Person> people = new List<Person>
{
    new Person { Id = 1, Name = "Giorgi", Age = 12 },
    new Person { Id = 2, Name = "Sandro", Age = 18 },
    new Person { Id = 3, Name = "Ksovreli", Age = 18 }
};

List<Orders> orders = new List<Orders>
{
    new Orders { PersonId = 1, Product = "Laptop"},
    new Orders { PersonId = 2, Product = "Phone"},
    new Orders { PersonId = 3, Product = "Ipad"}
};

static void Print<T>(IEnumerable<T> collection)
{
    foreach (T i in collection)
    {
        Console.WriteLine(i);
    }
}

var query = from person in people
            join order in orders on person.Id equals order.PersonId
            select new
            {
                PersonName = person.Name,
                OrderProduct = order.Product,
                PersonAge = person.Age
            };

var printGiorgi = query.Where(item => item.PersonName == "Giorgi");
Print(printGiorgi);

Console.WriteLine("========================");

Print(query);

Console.WriteLine("========================");

var printAdults = query.Where(a => a.PersonAge >= 18);
Print(printAdults);

Console.WriteLine("========================");

var sortByAge = query.OrderBy(a => a.PersonAge);
Print(sortByAge);

Console.WriteLine("========================");

var printOnlyNames = query.Select(n => n.PersonName);
Print(printOnlyNames);


class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public uint Age { get; set; }
}

class Orders
{
    public int PersonId { get; set; }
    public string Product { get; set; } = string.Empty;
}