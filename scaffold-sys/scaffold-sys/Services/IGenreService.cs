using SKA_Holding.Models;

namespace SKA_Holding.Services
{
    internal interface IGenreService
    {
        /// <summary>
        /// Creates a new movie genre.
        /// </summary>
        /// <param name="genre"></param>
        /// <returns>A new movie genre.</returns>
        Task CreateGenre(Genre genre);
        /// <summary>
        /// Gets all movie genres.
        /// </summary>
        /// <returns>all movie genres.</returns>

        List<Genre> GetGenres();
        /// <summary>
        /// Updates a movie genre.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="genre"></param>
        void UpdateGenre(int id, Genre genre);
        /// <summary>
        /// Deletes a movie genre by id.
        /// </summary>
        /// <param name="id"></param>
        void DeleteGenre(int id);
    }
}
