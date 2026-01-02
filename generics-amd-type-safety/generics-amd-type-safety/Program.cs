using FifteenthConsoleApp;

Pair<int, string> pair = new Pair<int, string>(7, "Hello World");
Console.Write($"First element: {pair.First}\tSecond element: {pair.Second}");

Console.WriteLine();

Minimum(5, 10);
Console.WriteLine($"Minimum: {Minimum(5, 10)}");

Minimum(5.5, 2.3);
Console.WriteLine($"Minimum: {Minimum(5.5, 2.3)}");
static T Minimum<T>(T a, T b) where T : IComparable<T>
{
    return a.CompareTo(b) < 0 ? a : b;
}
