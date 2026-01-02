using TwentiethConsoleApp;

//1. Word count example
string sentence = "This is an example sentence for counting words.";
Console.WriteLine($"sentence: {sentence}, wordcount {sentence.CountWords()}");

Console.WriteLine("===================================");

sentence = "   ";
Console.WriteLine($"sentence: '{sentence}', wordcount {sentence.CountWords()}");

Console.WriteLine("===================================");

sentence = "Claustrophobia is a phobia";
Console.WriteLine($"sentence: {sentence}, wordcount {sentence.CountWords()}");


//2. Enumerable filtering example
var items = new List<string> { "apple", null, "banana", null, "cherry" };

var filtered = items.WhereNotNull();

Console.WriteLine(string.Join(", ", filtered));


//3. Datetime formating example
DateTime today = DateTime.Now;
DateTime yesterday = DateTime.Now.AddDays(-1);
DateTime anotherDay = new DateTime(2025, 01, 23);

Console.WriteLine(today.ToFriendlyDate());
Console.WriteLine(yesterday.ToFriendlyDate());
Console.WriteLine(anotherDay.ToFriendlyDate());


//4. Number range checker example
int number = 10;
Console.WriteLine(number.IsInRange(5, 15));
Console.WriteLine(number.IsInRange(15, 20));

//5. List reversing example
var numbers = new List<int>{ 1, 2, 3, 4, 5 };
var reversedNumbers = numbers.ReverseList();
Console.WriteLine(string.Join(", ", reversedNumbers));