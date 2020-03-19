using RecipesAppNetCoreData.domain;
using RecipesAppNetCoreData.generic;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.repositories
{
    /// <summary>
    /// Unit of Measure Repository contract
    /// </summary>
    public interface IUnitOfMeasureRepository : ICrudRepository<UnitOfMeasure, long>
    {
        /// <summary>
        /// Gets Uom data searching by its Description
        /// </summary>
        /// <param name="description">Partial or full description</param>
        /// <returns>Unit of measure list that matches description</returns>
        public ICollection<UnitOfMeasure> GetByDescription(string description);
    }
}
