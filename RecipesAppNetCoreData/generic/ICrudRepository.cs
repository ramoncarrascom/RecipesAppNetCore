using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.generic
{
    /// <summary>
    /// Crud Repository interface
    /// </summary>
    /// <typeparam name="T">Entity data type</typeparam>
    /// <typeparam name="U">Entity id data type</typeparam>
    public interface ICrudRepository<T, U>
    {
        /// <summary>
        /// Get entity by its Id
        /// </summary>
        /// <param name="id">Entity Id</param>
        /// <returns>Requested data</returns>
        public T GetById(U id);

        /// <summary>
        /// Gets all the elements in table
        /// </summary>
        /// <returns>Requested data</returns>
        public ICollection<T> GetAll();
    }
}
