using System.Globalization;

namespace TwentiethConsoleApp
{
    internal static class NumericExtensions
    {
        public static bool IsInRange(this int number, int min, int max)
        {
            if (number >= min && number <= max)
            {
                return true;
            }
            return false;
        }

        public static string ToFriendlyDate(this DateTime date)
        {
            DateTime today = DateTime.Today;
            DateTime yesterday = DateTime.Today.AddDays(-1);

            if (date.Date == today)
            {
                return "Today";
            }

            else if (date.Date == yesterday)
            {
                return "Yesterday";
            }
            return date.ToString("dd MMMM, yyyy");
        }

        public static List<T> ReverseList<T>(this IEnumerable<T> collection)
        {
            var reversedList = collection.Reverse().ToList();
            return reversedList;
        }
    }
}
