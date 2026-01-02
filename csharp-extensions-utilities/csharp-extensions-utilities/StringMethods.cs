namespace TwentiethConsoleApp
{
    internal static class StringMethods
    {
        public static int CountWords(this string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return 0;
            }
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> src)
        {
            List<T> result = new List<T>();
            foreach (var item in src)
            {
                if (item != null)
                {
                    result.Add(item);
                }
            }
            return result;
        }
    }
}
