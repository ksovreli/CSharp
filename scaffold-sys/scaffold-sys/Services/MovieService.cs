using SKA_Holding.Data;
using SKA_Holding.Models;

namespace SKA_Holding.Services
{
    internal class MovieService : IMovieService
    {
        private readonly ImdbContext context = new ImdbContext();

        public async Task Create(Movie movie)
        {
            await context.Movies.AddAsync(movie);
            await context.SaveChangesAsync();
        }
        public List<Movie> GetMovies()
        {
            return context.Movies.ToList();
        }
        public void Update(int id, Movie movie)
        {
            var existingMovie = context.Movies.Find(id);
            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.ReleaseYear = movie.ReleaseYear;
                existingMovie.Duration = movie.Duration;
                existingMovie.Description = movie.Description;
                existingMovie.DirectorId = movie.DirectorId;
                existingMovie.ScreenWriterId = movie.ScreenWriterId;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var movie = context.Movies.Find(id);
            if (movie != null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }

            else
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Movie not found.");
            }
        }

    }
}
