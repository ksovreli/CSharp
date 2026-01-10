using SKA_Holding.Data;
using SKA_Holding.Models;

namespace SKA_Holding.Services
{
    internal interface IMovieService
    {
        /// <summary>
        /// This method creates a new movie.
        /// </summary>
        /// <param name="movie">New movie.</param>
        /// <returns>Movie.</returns>
        Task Create(Movie movie);
        /// <summary>
        /// This method updates an existing movie.
        /// </summary>
        /// <param name="id">id</param>
        /// <param name="movie"></param>
        void Update(int id, Movie movie);
        /// <summary>
        /// This method returns a list of movies.
        /// </summary>
        /// <returns>A list of movies.</returns>
        List<Movie> GetMovies();
        /// <summary>
        /// This method deletes a movie by id.
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);
    }
}
