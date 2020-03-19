using Microsoft.Extensions.DependencyInjection;
using RecipesAppNetCoreData.repositories;
using RecipesAppNetCoreData.repositories.implementation;
using RecipesAppNetCoreData.services;
using RecipesAppNetCoreData.services.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAppNetCore.ioc
{
    /// <summary>
    /// IOC repositories installer
    /// </summary>
    public class RepositoriesInstaller
    {
        private readonly IServiceCollection _services;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services">IServiceCollection object</param>
        public RepositoriesInstaller(IServiceCollection services)
        {
            this._services = services;
        }

        /// <summary>
        /// Installer method
        /// </summary>
        public void Install()
        {
            this._services.AddScoped(typeof(IUnitOfMeasureRepository), typeof(UnitOfMeasureRepository));
        }
    }
}
