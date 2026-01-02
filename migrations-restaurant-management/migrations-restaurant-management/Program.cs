using ConsoleAppSecondProject.KeyListener;
using ConsoleAppSecondProject.Manager;

BookManager bookManager = new BookManager();

bookManager.LoadData();

BookKeyListener bookKeyListener = new BookKeyListener(bookManager);
bookKeyListener.StartListening();

bookManager.SaveData();

Console.WriteLine("Thank you for using Book Manager!");
