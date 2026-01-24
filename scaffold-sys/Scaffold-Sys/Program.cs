using SKA_Holding.Models;
using SKA_Holding.Services;

IMovieService movieService = new MovieService();

Movie movie = new Movie()
{
    Title = "Inception",
    ReleaseYear = 2010,
    Duration = 148,
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
    Console.WriteLine($"Description: {m.Description}");
    Console.WriteLine($"Director ID: {m.DirectorId}");
    Console.WriteLine($"Screenwriter ID: {m.ScreenWriterId}");
    Console.WriteLine("--------------------------------------------------");
}

movie.Title = "Wonder (new)";
movieService.Update(movie.MovieId, movie);
Console.WriteLine("Movie updated successfully.\n");

await Task.Delay(2000);

movieService.Delete(movie.MovieId);
Console.WriteLine("Movie deleted successfully.\n");

await Task.Delay(2000);

DirectorService directorService = new DirectorService();

MovieDirector director = new MovieDirector()
{
    DirectorName = "Christopher",
    DirectorSurname = "Nolan"
};

await directorService.CreateDirector(director);
Console.WriteLine("Director created successfully.\n");

await Task.Delay(2000);

Console.WriteLine("All directors in the database: ");
var directors = directorService.GetDirectors();
foreach (var d in directors)
{
    Console.WriteLine($"ID: {d.DirectorId}");
    Console.WriteLine($"Name: {d.DirectorName}");
    Console.WriteLine($"Surname: {d.DirectorSurname}");
    Console.WriteLine("--------------------------------------------------");
}
director.DirectorSurname = "Nolan (new)";
directorService.UpdateDirector(director.DirectorId, director);

Console.WriteLine("Director updated successfully.\n");

await Task.Delay(2000);

directorService.DeleteDirector(director.DirectorId);
Console.WriteLine("Director deleted successfully.\n");

await Task.Delay(2000);

GenreService genreService = new GenreService();
Genre genre = new Genre()
{
    GenreName = "Science Fiction"
};

await genreService.CreateGenre(genre);
Console.WriteLine("Genre created successfully.\n");

await Task.Delay(2000);
Console.WriteLine("All genres in the database: ");
var genres = genreService.GetGenres();
foreach (var g in genres)
{
    Console.WriteLine($"ID: {g.GenreId}");
    Console.WriteLine($"Name: {g.GenreName}");
    Console.WriteLine("--------------------------------------------------");
}
genre.GenreName = "Sci-Fi (new)";

genreService.UpdateGenre(genre.GenreId, genre);
Console.WriteLine("Genre updated successfully.\n");

await Task.Delay(2000);

genreService.DeleteGenre(genre.GenreId);
Console.WriteLine("Genre deleted successfully.\n");

await Task.Delay(2000);
Console.WriteLine("All operations completed.");
