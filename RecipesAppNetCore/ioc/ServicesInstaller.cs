using Microsoft.Extensions.DependencyInjection;
using RecipesAppNetCoreData.services;
using RecipesAppNetCoreData.services.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesAppNetCore.ioc
{
    public class ServicesInstaller
    {
        private readonly IServiceCollection _services;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="services">IServiceCollection object</param>
        public ServicesInstaller(IServiceCollection services)
        {
            this._services = services;
        }

        /// <summary>
        /// Installer method
        /// </summary>
        public void Install()
        {
            this._services.AddScoped(typeof(IUnitOfMeasureService), typeof(UnitOfMeasureService));
        }
    }
}
