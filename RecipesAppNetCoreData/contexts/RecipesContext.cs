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
        public RecipesContext(DbContextOptions options) : base(options) { }

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
                optionsBuilder.UseMySql(@"server=192.168.100.101;database=recipes_net;user=recipesuser;password=1234");
            }            
        }

        /// <summary>
        /// Model configuration
        /// </summary>
        /// <param name="modelBuilder">Model builder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigurePrimaryKeys(modelBuilder);
            ConfigureJoinTables(modelBuilder);
            ConfigureOneToOneRelation(modelBuilder);
            InitializeData(modelBuilder);
        }

        /// <summary>
        /// PK configuration
        /// </summary>
        /// <param name="modelBuilder">Model builder</param>
        private void ConfigurePrimaryKeys(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasKey(recipe => recipe.Id);
            modelBuilder.Entity<Category>().HasKey(category => category.Id);
            modelBuilder.Entity<Ingredient>().HasKey(ingredient => ingredient.Id);
            modelBuilder.Entity<Note>().HasKey(note => note.Id);
            modelBuilder.Entity<UnitOfMeasure>().HasKey(uom => uom.Id);
        }

        /// <summary>
        /// Join tables configuration for many-to-many relation
        /// </summary>
        /// <param name="modelBuilder">Model builder</param>
        private void ConfigureJoinTables(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RecipeCategory>().HasKey(rc => new { rc.CategoryId, rc.RecipeId });
            modelBuilder.Entity<RecipeCategory>().HasOne(rc => rc.Recipe).WithMany(r => r.RecipeCategories).HasForeignKey(bc => bc.RecipeId);
            modelBuilder.Entity<RecipeCategory>().HasOne(ca => ca.Category).WithMany(c => c.RecipeCategories).HasForeignKey(ca => ca.CategoryId);
        }

        /// <summary>
        /// One-to-one relation configuration
        /// </summary>
        /// <param name="modelBuilder">Model builder</param>
        private void ConfigureOneToOneRelation(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>().HasOne(rc => rc.Note).WithOne(nt => nt.Recipe).HasForeignKey<Note>(nt => nt.RecipeId);
        }

        /// <summary>
        /// Master data initialization
        /// </summary>
        /// <param name="modelBuilder">Model builder</param>
        private void InitializeData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UnitOfMeasure>().HasData(new UnitOfMeasure(1, "Tablespoon"));
            modelBuilder.Entity<UnitOfMeasure>().HasData(new UnitOfMeasure(2, "Cup"));
            modelBuilder.Entity<UnitOfMeasure>().HasData(new UnitOfMeasure(3, "Pint"));
            modelBuilder.Entity<UnitOfMeasure>().HasData(new UnitOfMeasure(4, "Each"));
            modelBuilder.Entity<UnitOfMeasure>().HasData(new UnitOfMeasure(5, "Teaspoon"));
            modelBuilder.Entity<UnitOfMeasure>().HasData(new UnitOfMeasure(6, "Dash"));
        }
    }
}
