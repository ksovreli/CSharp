
// დავალება 1

//Console.WriteLine("Enter N: ");
//int n;
//n = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    for (int j = 1; j <= n; j++)
//    {
//        Console.WriteLine($"{j}x{i} = {j * i}");
//    }
//    Console.WriteLine();
//}


// დავალება 2

//Console.WriteLine("Enter N: ");
//int n;
//n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//for (int i = 1; i <= n; i++)
//{
//    sum += i;
//}

//Console.WriteLine($"{n} number's sum: {sum}");


// დავალება 3

//Console.WriteLine("Enter Number To Build Pyramid");
//int n;
//n = Convert.ToInt32(Console.ReadLine());

//for (int i = 0; i < n; i++)
//{
//    Console.Write(new string(' ', n - i));
//    for (int j = 0; j < i + 1; j++)
//    {
//        Console.Write($"{j + 1} ");
//    }
//    Console.WriteLine();
//}

// დავალება 4

//Console.WriteLine("Enter Quantity Of Even Numbers: ");
//int n;
//n = Convert.ToInt32(Console.ReadLine());
//int even;
//int sum = 0;

//Console.WriteLine($"Even quantity is: {n}");

//for (int i = 1; i <= n; i++)
//{
//    even = i * 2;
//    Console.Write(even);
//    sum += even;
//}

//Console.WriteLine($" Even numbers sum = {sum} ");

// დავალება 5

//Console.Write("Enter a positive number n: ");

//int n = Convert.ToInt32(Console.ReadLine());
//int sum = 0;

//for (int i = 1; i <= n; i++)
//{
//    int square = (int) Math.Pow(i, 2);
//    Console.WriteLine($"{i}^2 = {square}");
//    sum += square;
//}

//Console.WriteLine($"Sum of squares = {sum}");



//დავალება 6

//Console.WriteLine("Enter N: ");

//int n;
//bool isPrime = true;
//n = Convert.ToInt32(Console.ReadLine());

//for(int i = 2; i < n; i++)
//{
//    if (n % i == 0)
//    {
//        isPrime = false;
//        break;
//    }
//}

//string result = isPrime ? $"{n} is prime" : $"{n} is not prime";
//Console.WriteLine(result);

//string[] names = new string[4];

//Console.WriteLine("Enter name");

//names[1] = "Sandro";
//names[2] = "Giorgi";
//names[3] = "Doe";

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}



// Printing numbers between 1 - 100

//int[,] array = new int[3, 4];
//Random random = new Random();

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for(int j = 0; j < array.GetLength(1); j++)
//    {
//        array[i, j] = random.Next(1, 101);
//        Console.Write(array[i, j] + "\t");
//    }
//    Console.WriteLine();
//}   


//char[] grades = new char[2];

//foreach (char c in grades)
//{

//    Console.WriteLine(c);
//}

//for (int i = 0; i < grades.Length; i++)
//{
//    grades[i] = 'A';
//    Console.WriteLine(grades[i]);
//} 


//int[] arr1 = new int[3] { 7, 1, 9 };
//int[] arr2 = new int[3] { 7, 1, 9 };

//for (int i = 0; i < arr1.Length; i++)
//{
//    arr2[i] = arr1[i];
//    Console.WriteLine(arr2[i]);
//}

