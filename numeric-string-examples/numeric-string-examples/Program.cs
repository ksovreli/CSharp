using TwentyFirstConsoleApp;

Console.WriteLine($"Factorial of 5 is: {NumericExtensions.Factorial(5)}");
Console.WriteLine($"Factorial of 10 is: {NumericExtensions.Factorial(10)}");
Console.WriteLine($"Factorial of 15 is: {NumericExtensions.Factorial(15)}");

var numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };

var uniqueNumbers = NumericExtensions.RemoveDuplicates(numbers);
Console.WriteLine("\nUnique numbers:");
NumericExtensions.Print(uniqueNumbers);

var avgNumbers = NumericExtensions.Average(numbers);
Console.WriteLine($"\nAverage number is: {avgNumbers}");
