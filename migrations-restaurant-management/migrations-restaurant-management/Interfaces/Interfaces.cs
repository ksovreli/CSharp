using ConsoleAppSecondProject.Enums;

namespace ConsoleAppSecondProject.Interfaces
{
        /// <summary>
        /// Adds an object.
        /// </summary>
        ///
        interface ICreateable<T> where T : class
        {
            void Add(T obj);
        }
        
        /// <summary>
        /// Gets every object.
        /// </summary>
        ///
        interface IReadable<T> where T : class
        {
            List<T> GetAll();
        }
        
        /// <summary>
        /// Updates genre.
        /// </summary>
        ///
        interface IUpdateable<T> where T : class
        {
            void Update(Genre genre, string title);
        }
        
        /// <summary>
        /// Deletes movie.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        interface IDeleteable<T> where T : class
        {
            void Remove(T obj);
        }
}
