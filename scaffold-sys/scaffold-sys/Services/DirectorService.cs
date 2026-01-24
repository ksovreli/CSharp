using SKA_Holding.Data;
using SKA_Holding.Models;

namespace SKA_Holding.Services
{
    internal class DirectorService : IDirectorService
    {
        private readonly ImdbContext context = new ImdbContext();

        public async Task CreateDirector(MovieDirector director)
        {
            await context.MovieDirectors.AddAsync(director);
            await context.SaveChangesAsync();
        }

        public List<MovieDirector> GetDirectors()
        {
            return context.MovieDirectors.ToList();
        }

        public void UpdateDirector(int id, MovieDirector director)
        {
            var existingDirector = context.MovieDirectors.Find(id);

            if (existingDirector != null)
            {
                existingDirector.DirectorName = director.DirectorName;
                existingDirector.DirectorSurname = director.DirectorSurname;
                context.SaveChanges();
            }
        }

        public void DeleteDirector(int id)
        {
            var existingDirector = context.MovieDirectors.Find(id);
            if (existingDirector != null)
            {
                context.MovieDirectors.Remove(existingDirector);
                context.SaveChanges();
            }

            else
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Director not found.");
            }
        }
    }
}
