namespace TwentyFirstConsoleApp
{
    internal static class NumericExtensions
    {
        public static int Factorial(this int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("Number must be positive.");
            }

            int sum = 1;

            for (int i = 1; i <= number; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public static List<T> RemoveDuplicates<T> (this List<T> list)
        {
            var removeDuplicates = list.Distinct().ToList();
            return removeDuplicates;
        }

        public static double Average(IEnumerable<int> numbers)
        {
            ArgumentNullException.ThrowIfNull(numbers);

            int sum = 0;
            int count = 0;

            foreach (var n in numbers)
            {
                sum += n;
                count++;
            }

            if (count == 0)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            return (double)sum / count;
        }

        public static void Print<T>(IEnumerable<T> collection)
        {
            foreach (T i in collection)
            {
                Console.WriteLine(i);
            }
        }
    }
}
