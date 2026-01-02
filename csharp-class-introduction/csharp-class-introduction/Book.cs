using SeventhConsoleApp.Enums;

namespace SeventhConsoleApp
{
    internal class Book
    {
        private DateTime _releasedDate;
        public string Title { get; init; }
        public List<Author> Author { get; init; }
        public string ISBN { get; init; }
        public Genre Genre { get; init; }
        public DateTime ReleasedDate {
            get
            {
                return _releasedDate;
            }

            init
            {
                if (value > DateTime.Now)
                {
                    Console.WriteLine("datetime is greater than value");
                }

                else
                {
                    _releasedDate = value;
                }
            }
        }
        public uint Quantity { get; set; }

        public Book()
        {

        }

        public Book(string Title, List<Author> Author, string ISBN, Genre Genre, DateTime ReleasedDate, uint Quantity)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
            this.Genre = Genre;
            this.ReleasedDate = ReleasedDate;
            this.Quantity = Quantity;
        }

        public void Print()
        {
            Console.WriteLine(
            $"\n\tTitle: {Title}, " +
            $"\n\tAuthor: {Author}, " +
            $"\n\tISBN: {ISBN}, " +
            $"\n\tGenre: {Genre}, " +
            $"\n\tReleasedDate: {ReleasedDate}," +
            $"\n\tQuantity: {Quantity}");
        }
    }
}
