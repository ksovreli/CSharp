// filter example 1

//List<string> names = new List<string>
//{
//    "Sandro",
//    "Giorgi",
//    "Nikusha",
//    "Elene",
//    "Mari"
//};

//Predicate<string> filter = name => name.Length > 5;
//foreach (var name in names)
//{
//    if (filter(name))
//    {
//        Action<string> upperCase = name => Console.WriteLine(name.ToUpper());
//        upperCase(name);
//    }
//}


// difference delegate example 2

//Operation sumDelegate = Sum;
//sumDelegate += Subtract;
//sumDelegate += Divide;

//Console.WriteLine("Enter first number: ");
//double num1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter second number: ");
//double num2 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Enter third number: ");
//double num3 = Convert.ToDouble(Console.ReadLine());

//sumDelegate(num1, num2, num3);

//static double Sum (double a, double b, double c)
//{
//    double result = a + b + c;
//    Console.WriteLine($"{a} + {b} + {c} = {result}");
//    return result;
//}

//static double Subtract (double a, double b, double c)
//{
//    double result = a - b - c;
//    Console.WriteLine($"{a} - {b} - {c} = {result}");
//    return result;
//}

//static double Divide (double a, double b, double c)
//{
//    double result = a / b / c;
//    Console.WriteLine($"{a} / {b} / {c} = {result}");
//    return result;
//}

//delegate double Operation(double a, double b, double c);

