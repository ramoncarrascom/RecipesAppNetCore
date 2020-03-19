using RecipesAppNetCoreData.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.services
{
    /// <summary>
    /// Unit of Measure Service Contract
    /// </summary>
    public interface IUnitOfMeasureService
    {
        /// <summary>
        /// Gets all Uoms
        /// </summary>
        /// <returns>Requested data</returns>
        public ICollection<UnitOfMeasure> GetAll();

        /// <summary>
        /// Gets a specific Uom using its Id
        /// </summary>
        /// <param name="Id">Id to find</param>
        /// <returns>Requested data</returns>
        public UnitOfMeasure GetById(long Id);

        /// <summary>
        /// Filters Uom list using a description
        /// </summary>
        /// <param name="Id">Text to find</param>
        /// <returns>Requested data</returns>
        public ICollection<UnitOfMeasure> GetByDescription(string Description);
    }
}
