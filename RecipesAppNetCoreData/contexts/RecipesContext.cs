using Microsoft.EntityFrameworkCore;
using RecipesAppNetCoreData.domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.contexts
{
    /// <summary>
    /// Recipes context configuration for Entity Framework
    /// </summary>
    public class RecipesContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Note> Notes { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<UnitOfMeasure> Uoms { get; set; }

        /// <summary>
        /// Context configuration
        /// </summary>
        /// <param name="optionsBuilder">Context options builder</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL(@"server=192.168.100.101;database=recipes_net;user=recipesuser;password=1234");
            }            
        }
    }
}
