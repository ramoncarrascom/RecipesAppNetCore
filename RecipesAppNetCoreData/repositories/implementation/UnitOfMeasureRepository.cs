using Microsoft.EntityFrameworkCore;
using RecipesAppNetCoreData.contexts;
using RecipesAppNetCoreData.domain;
using RecipesAppNetCoreData.generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipesAppNetCoreData.repositories.implementation
{
    public class UnitOfMeasureRepository : IUnitOfMeasureRepository
    {
        private readonly RecipesContext _recipes;
        private readonly DbSet<UnitOfMeasure> _dbSet;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="recipes">Recipes context</param>
        public UnitOfMeasureRepository(RecipesContext recipes)
        {
            this._recipes = recipes;
            this._dbSet = _recipes.Uoms;
        }

        /// <summary>
        /// Gets all Units of Measure
        /// </summary>
        /// <returns>Requested data</returns>
        public ICollection<UnitOfMeasure> GetAll()
        {
            return _dbSet.ToList<UnitOfMeasure>();
        }

        /// <inheritdoc />
        public ICollection<UnitOfMeasure> GetByDescription(string description)
        {
            return _dbSet
                    .Where(uom => uom.Description.ToLower().Contains(description.ToLower())).ToList();
        }

        /// <summary>
        /// Gets Uom data searching by its Id
        /// </summary>
        /// <param name="id">Identifier</param>
        /// <returns>Requested data</returns>
        public UnitOfMeasure GetById(long id)
        {
            return _dbSet.Find(id);
        }
    }
}
