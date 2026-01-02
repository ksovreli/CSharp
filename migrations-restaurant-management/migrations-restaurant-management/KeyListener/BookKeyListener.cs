using ConsoleAppSecondProject.Enums;
using ConsoleAppSecondProject.Manager;
using ConsoleAppSecondProject.Models;

namespace ConsoleAppSecondProject.KeyListener
{
    internal class BookKeyListener
    {
        private readonly BookManager _bookManager;

        public BookKeyListener(BookManager bookManager)
        {
            _bookManager = bookManager;
        }

        public void StartListening()
        {

            while (true)
            {
                Console.WriteLine("\n--- Book Manager ---");
                Console.WriteLine("[1]. Add New Book");
                Console.WriteLine("[2]. Remove Book");
                Console.WriteLine("[3]. View All Book");
                Console.WriteLine("[4]. Search Book By Title");
                Console.WriteLine("[5]. Search Book Title By Author");
                Console.WriteLine("[6]. Update Book Genre");
                Console.WriteLine("[7]. Save And Exit");
                Console.WriteLine("Choose an option: ");

                var x = Console.ReadKey(true);

                if (x.Key == ConsoleKey.D7)
                {
                    _bookManager.SaveData();
                    Console.WriteLine("\nBooks saved. You have exited the program.\n");
                    break;
                }

                switch (x.Key)
                {
                    case ConsoleKey.D1:
                        {
                            Console.WriteLine("Enter Book Title: ");
                            string title = Console.ReadLine() ?? string.Empty;

                            Console.WriteLine("Enter Author: ");
                            string author = Console.ReadLine() ?? string.Empty;

                            Console.WriteLine("Enter Release Year: ");
                            int releaseYear = Convert.ToInt32(Console.ReadLine());

                            Genre genre;
                            while (true)
                            {
                                Console.WriteLine("Select Genre:");
                                Console.WriteLine("0 = SciFi");
                                Console.WriteLine("1 = Drama");
                                Console.WriteLine("2 = Comedy");
                                Console.WriteLine("3 = Horror");
                                string input = Console.ReadLine() ?? string.Empty;

                                if (int.TryParse(input, out int genreInput) && Enum.IsDefined(typeof(Genre), genreInput))
                                {
                                    genre = (Genre)genreInput;
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Invalid genre. Please enter 0, 1, 2, or 3.");
                                }
                            }

                            Book newBook = new Book(title, author, releaseYear, genre);
                            _bookManager.Add(newBook);
                            Console.WriteLine("Book added!");
                            break;
                        }

                    case ConsoleKey.D2:
                        {
                            Console.WriteLine("Enter book title to remove: ");
                            string title = Console.ReadLine() ?? string.Empty;

                            if (_bookManager.SearchBookByTitle(title, out Book? bookToRemove) && bookToRemove != null)
                            {
                                _bookManager.Remove(bookToRemove);
                                Console.WriteLine($"Book '{bookToRemove.Title}' removed successfully!");
                            }

                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            break;
                        }

                    case ConsoleKey.D3:
                        {
                            var allBooks = _bookManager.GetAll();
                            if (allBooks.Count == 0)
                            {
                                Console.WriteLine("No books found.");
                                continue;
                            }

                            else
                            {
                                foreach (var b in allBooks)
                                {
                                    Console.WriteLine("-----------------");
                                    Console.WriteLine($"\nTitle: {b.Title}");
                                    Console.WriteLine($"Author: {b.Author}");
                                    Console.WriteLine($"Year: {b.ReleaseYear}");
                                    Console.WriteLine($"Genre: {b.Genre}");
                                    Console.WriteLine("-----------------");
                                }

                            }

                            break;
                        }

                    case ConsoleKey.D4:
                        {
                            Console.WriteLine("Enter book title to search: ");
                            string searchTitle = Console.ReadLine() ?? string.Empty;

                            if (_bookManager.SearchBookByTitle(searchTitle, out Book? book))
                            {
                                Console.WriteLine("Book found:");
                                Console.WriteLine($"\n{book?.ToString()}");
                            }

                            else
                            {
                                Console.WriteLine("Book not found.");
                                continue;
                            }
                            break;
                        }

                    case ConsoleKey.D5:
                        {
                            Console.WriteLine("Enter author name to search: ");
                            string searchAuthor = Console.ReadLine() ?? string.Empty;

                            if (_bookManager.SearchBooksByAuthor(searchAuthor, out List<string> bookTitles))
                            {
                                Console.WriteLine("Books found:");
                                foreach (var t in bookTitles)
                                {
                                    Console.WriteLine($"Title: {t}");
                                }
                            }

                            else
                            {
                                Console.WriteLine("No books found for this author.");
                                continue;
                            }
                            break;
                        }

                    case ConsoleKey.D6:
                        {
                            Console.Write("Enter the title of the books to update: ");
                            string searchTitle = Console.ReadLine() ?? string.Empty;

                            if (_bookManager.SearchBookByTitle(searchTitle, out Book? book) && book != null)
                            {
                                Console.WriteLine("Select new Genre:");
                                Console.WriteLine("0 = SciFi");
                                Console.WriteLine("1 = Drama");
                                Console.WriteLine("2 = Comedy");
                                Console.WriteLine("3 = Horror");
                                int genreInput = Convert.ToInt32(Console.ReadLine());
                                book.Genre = (Genre)genreInput;

                                Console.WriteLine($"Genre for '{book.Title}' updated to {book.Genre}!");
                            }

                            else
                            {
                                Console.WriteLine("Book not found.");
                            }
                            break;
                        }


                    default:
                        Console.WriteLine("Invalid key.");
                        break;
                }
            }
        }
    }
}
