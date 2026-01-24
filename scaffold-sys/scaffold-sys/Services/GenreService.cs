using SKA_Holding.Data;
using SKA_Holding.Models;

namespace SKA_Holding.Services
{
    internal class GenreService : IGenreService
    {
        private readonly ImdbContext context = new ImdbContext();

        public async Task CreateGenre(Genre genre)
        {
            await context.Genres.AddAsync(genre);
            await context.SaveChangesAsync();
        }
        public List<Genre> GetGenres()
        {
            return context.Genres.ToList();
        }

        public void UpdateGenre(int id, Genre genre)
        {
            var existingGenre = context.Genres.Find(id);

            if (existingGenre != null)
            {
                existingGenre.GenreId = genre.GenreId;
                existingGenre.GenreName = genre.GenreName;
                context.SaveChanges();
            }
        }

        public void DeleteGenre(int id)
        {
            var genre = context.Genres.Find(id);
            if (genre != null)
            {
                context.Genres.Remove(genre);
                context.SaveChanges();
            }
        }
    }
}
