using RecipesAppNetCoreData.domain;
using RecipesAppNetCoreData.repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.services.implementation
{
    /// <summary>
    /// Unit of Measure Service
    /// </summary>
    public class UnitOfMeasureService : IUnitOfMeasureService
    {
        private readonly IUnitOfMeasureRepository _repository;

        /// <summary>
        /// Constructor
        /// </summary>
        public UnitOfMeasureService(IUnitOfMeasureRepository repository)
        {
            this._repository = repository;
        }

        /// <inheritdoc/>
        public ICollection<UnitOfMeasure> GetAll()
        {
            return this._repository.GetAll();
        }

        /// <inheritdoc/>
        public ICollection<UnitOfMeasure> GetByDescription(string Description)
        {
            return this._repository.GetByDescription(Description);
        }

        /// <inheritdoc/>
        public UnitOfMeasure GetById(long Id)
        {
            return this._repository.GetById(Id);
        }
    }
}
