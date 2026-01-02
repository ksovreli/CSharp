

// დავალება 1 მეთოდები

//Console.WriteLine("Enter first number: ");
//int a;
//a = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Enter second number: ");
//int b;
//b = Convert.ToInt32(Console.ReadLine());

//int result = pow(a, b);

//static int pow(int x, int y)
//{
//    int power = 1;

//    for(int i = 0; i < y; i++)
//    {
//        power *= x;
//    }
//    return power;
//}

//Console.WriteLine(result);  



// დავალება 2 მეთოდები

//Console.WriteLine("Enter number: ");
//int number;
//number = Convert.ToInt32(Console.ReadLine());

//static void isPrimeNumber(int n)
//{
//    bool isPrime = true;

//    for (int i = 2; i < n; i++)
//    {
//        if(n % i == 0)
//        {
//            isPrime = false;
//            break;
//        }
//    }
//    if (isPrime)
//    {
//        Console.WriteLine($"{n} is prime number");
//    }

//    else
//    {
//        Console.WriteLine($"{n} is not prime number");
//    }
//}


//isPrimeNumber(number);

// დავალება 3 მეთოდები

//static int isPalidrome(string text)
//{
//    Console.WriteLine("Enter text you want to check if its palidrome: ");
//    text = Console.ReadLine() ?? string.Empty;
//    string reversedText = string.Empty;

//    for (int i = text.Length - 1; i >= 0; i--)
//    {
//        reversedText += text[i];
//    }

//    if (text.Equals(reversedText, StringComparison.OrdinalIgnoreCase))
//    {
//        return 1;
//    }

//    else
//    {
//        return 0;
//    }
//}

//Console.WriteLine(isPalidrome("mamam"));


// დავალება 4 მეთოდები

//int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

//static void evenCount(int[] numbers)
//{
//    int countEven = 0;
//    int sum = 0;

//    foreach (int number in numbers)
//    {
//        if (number % 2 == 0)
//        {
//            Console.Write(number + " + ");
//            sum += number;
//            countEven++;
//        }
//    }
//    Console.WriteLine($"even count is {countEven} and sum is {sum}");
//}

//evenCount(numbers);




// მარტივი რიცხვი  1

//int n;
//Console.WriteLine("Enter number: ");
//n = Convert.ToInt32(Console.ReadLine());
//string result = isPrime(n)
//    ? $"{n} is a prime number"
//    : $"{n} is not a prime number";

//Console.WriteLine(result);
//static bool isPrime(int number)
//{

//    for (int i = 2; i < number; i++)
//    {
//        if (number % i == 0)
//        {
//            return false;
//        }
//    }
//    return true;
//}


//using SixthConsoleApp;
//User user = new User();
//user.Name = "John";
//user.Surname = "Doe";

//User user1 = new User("", "", "", DateTime.Now);
//User user2 = new User("name", "lastname");

//int age = user1.getAge();
//user1.Print();


//StudentClass student = new StudentClass();
//student.name = "Jane";
//student.surname = "Smith";
//student.Print();

// დავალება 1 კლასები და მეთოდები

using SixthConsoleApp;
Lector lector = new Lector();
Lector lector1 = new Lector("Sandro", "Ksovreli");
Lector lector2 = new Lector("Mate", "Edisherashvili");
lector1.Print();
lector2.Print();