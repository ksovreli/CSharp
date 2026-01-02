using ConsoleAppSecondProject.Enums;
using ConsoleAppSecondProject.Interfaces;
using ConsoleAppSecondProject.Models;
using System.Xml.Serialization;

namespace ConsoleAppSecondProject.Manager
{
    internal class BookManager: ICreateable<Book>, IReadable<Book>, IUpdateable<Book>, IDeleteable<Book>
    {
        private readonly List<Book> _books;

        public BookManager()
        {
            _books = new List<Book>();
        }

        /// <summary>
        /// Gets all book from the collection.
        /// </summary>
        /// <returns>list of bookss.</returns>
        public List<Book> GetAll()
        {
            return _books;
        }

        /// <summary>
        /// Adds a new book.
        /// </summary>
        /// 
        public void Add(Book book)
        {
            _books.Add(book);
        }

        /// <summary>
        /// Removes a specific book.
        /// </summary>
        ///
        public void Remove(Book book)
        {
            _books.Remove(book);
        }

        /// <summary>
        /// Searchs book by title
        /// </summary>
        /// <returns>Book by title</returns>
        public bool SearchBookByTitle(string title, out Book? book)
        {
            book = _books.FirstOrDefault(m => m.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            return book != null;
        }

        /// <summary>
        /// Searches book by author
        /// </summary>
        /// <returns>returns book title</returns>
        public bool SearchBooksByAuthor(string author, out List<string> bookTitles)
        {
            bookTitles = _books
                .Where(m => m.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
                .Select(m => m.Title)
                .ToList()!;

            return bookTitles.Count > 0;
        }

        /// <summary>
        /// Updates genre by title,
        /// </summary>
        public void Update(Genre genre, string title)
        {
            _ = SearchBookByTitle(title, out Book? book);
            if (book != null)
            {
                book.Genre = genre;
            }
        }

        /// <summary>
        /// Saves data.
        /// </summary>
        public void SaveData()
        {
            string projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? string.Empty;
            string folderDir = Path.Combine(projectDir, "Data");


            if (!Directory.Exists(folderDir))
            {
                Directory.CreateDirectory(folderDir);
            }

            string filePath = Path.Combine(folderDir, "Book.xml");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            using StreamWriter sw = new StreamWriter(filePath);
            xmlSerializer.Serialize(sw, _books);
        }

        /// <summary>
        /// Loads data.
        /// </summary>
        public void LoadData()
        {
            string projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName ?? string.Empty;
            string folderDir = Path.Combine(projectDir, "Data");
            string filePath = Path.Combine(folderDir, "Book.xml");

            if (!File.Exists(filePath))
            {
                _books.Clear();
                return;
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Book>));
            using StreamReader sr = new StreamReader(filePath);
            _books.Clear();
            _books.AddRange((List<Book>)xmlSerializer.Deserialize(sr)!);
        }
    }
}
