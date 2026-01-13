using SKA_Holding.Data;
using SKA_Holding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKA_Holding.Services
{
    internal class MovieService : IMovieService
    {
        private readonly ImdbContext context = new ImdbContext();

        public async Task Create(Movie movie)
        {
            await context.Movie.AddAsync(movie);
            await context.SaveChangesAsync();
        }
        public List<Movie> GetMovies()
        {
            return context.Movie.ToList();
        }
        public void Update(int id, Movie movie)
        {
            var existingMovie = context.Movie.Find(id);
            if (existingMovie != null)
            {
                existingMovie.Title = movie.Title;
                existingMovie.ReleaseYear = movie.ReleaseYear;
                existingMovie.Duration = movie.Duration;
                existingMovie.Rating = movie.Rating;
                existingMovie.Description = movie.Description;
                existingMovie.DirectorId = movie.DirectorId;
                existingMovie.ScreenWriterId = movie.ScreenWriterId;
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var movie = context.Movie.Find(id);
            if (movie != null)
            {
                context.Movie.Remove(movie);
                context.SaveChanges();
            }

            else
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Movie not found.");
            }
        }

    }
}
