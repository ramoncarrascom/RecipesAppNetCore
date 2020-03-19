using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RecipesAppNetCore.ioc;
using RecipesAppNetCoreData.contexts;

namespace RecipesAppNetCore
{
    public class Startup
    {
        /// <summary>
        /// Stores app settings
        /// </summary>
        private readonly IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        /// <summary>
        /// Called by runtime. Used for services and IOC config
        /// </summary>
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddDbContext<RecipesContext>(options => options.UseMySql(Configuration.GetConnectionString("MySql")));

            new ServicesInstaller(services).Install();
            new RepositoriesInstaller(services).Install();
        }

        /// <summary>
        /// Called by runtime. Configures pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
