using SKA_Holding.Models;
using SKA_Holding.Services;

IMovieService movieService = new MovieService();

Movie movie = new Movie()
{
    Title = "Inception",
    ReleaseYear = 2010,
    Duration = 148,
    Rating = 8.8m,
    Description = "A mind-bending thriller about dreams.",
    DirectorId = 1,
    ScreenWriterId = 1
};

await movieService.Create(movie);
Console.WriteLine("Movie created successfully.\n");

await Task.Delay(2000);

Console.WriteLine("All movies in the database: ");
var movies = movieService.GetMovies();
foreach (var m in movies)
{
    Console.WriteLine($"ID: {m.MovieId}");
    Console.WriteLine($"Title: {m.Title}");
    Console.WriteLine($"Year: {m.ReleaseYear}");
    Console.WriteLine($"Duration: {m.Duration} min");
    Console.WriteLine($"Rating: {m.Rating}");
    Console.WriteLine($"Description: {m.Description}");
    Console.WriteLine($"Director ID: {m.DirectorId}");
    Console.WriteLine($"Screenwriter ID: {m.ScreenWriterId}");
    Console.WriteLine(new string('-', 50));
}

movie.Title = "Wonder (new)";
movieService.Update(movie.MovieId, movie);
Console.WriteLine("Movie updated successfully.\n");

await Task.Delay(2000);

movieService.Delete(movie.MovieId);
Console.WriteLine("Movie deleted successfully.\n");
