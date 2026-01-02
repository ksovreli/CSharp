using ConsoleAppSecondProject.Enums;

namespace ConsoleAppSecondProject.Models
{
    /// <summary>
    /// Book Class
    /// </summary>
    public class Book
    {
        private string _title = null!;
        private string _author = null!;
        private int _releaseYear;
        private Genre _genre;

        /// <summary>
        /// Title, cannot be nullk
        /// </summary>
        public string Title
        { 
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Title cannot be empty.");
                }
                _title = value;
            }
        }

        /// <summary>
        /// Author, cannot be null.
        /// </summary>
        public string Author 
        {
            get => _author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(value), "Author cannot be empty.");
                }
                _author = value;
            }
        }

        /// <summary>
        /// Release year, from 1920 to the current year.
        /// </summary>
        public int ReleaseYear 
        { 
            get => _releaseYear;
            set
            {
                if (value < 1920 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), $"Release year must be between 1920 and {DateTime.Now.Year}");
                }
                _releaseYear = value;
            }
        }

        /// <summary>
        /// Genre
        /// </summary>
        public Genre Genre 
        { 
            get => _genre;
            set
            {
                if (!Enum.IsDefined(typeof(Genre), value))
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Genre value is not valid.");
                }
                _genre = value;
            }
        }

        public Book() { }
        public Book(string title, string author, int releaseYear, Genre genre)
        {
            this.Title = title;
            this.Author = author;
            this.ReleaseYear = releaseYear;
            this.Genre = genre;
        }

        /// <summary>
        /// Print method.
        /// </summary>
        /// <returns>Book details.</returns>
        public override string ToString()
        {
            return 
                $"Title: {Title}" +
                $"\nAuthor: {Author}" +
                $"\nRelease Year: {ReleaseYear}" +
                $"\nGenre: {Genre}";
        }
    }
}
