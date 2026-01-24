using SKA_Holding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SKA_Holding.Services
{
    internal interface IDirectorService
    {
        /// <summary>
        /// Creates a new movie director.
        /// </summary>
        /// <param name="director"></param>
        /// <returns></returns>
        Task CreateDirector(MovieDirector director);
        /// <summary>
        /// This method returns a list of all movie directors.
        /// </summary>
        /// <returns>A list of directors.</returns>
        List<MovieDirector> GetDirectors();
        /// <summary>
        /// Updates an existing movie director.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="director"></param>
        /// <returns>An updated director</returns>
        void UpdateDirector(int id, MovieDirector director);
        /// <summary>
        /// Deletes specific director..
        /// </summary>
        /// <param name="id"></param>
        void DeleteDirector(int id);
    }
}
