using System;
using System.Collections.Generic;
using System.Text;

using RecipesAppNetCoreData.domain.enums;

namespace RecipesAppNetCoreData.domain
{
    /// <summary>
    /// Recipe data model
    /// </summary>
    public class Recipe
    {
        public long Id { get; set; }
        public ICollection<RecipeCategory> RecipeCategories { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public Note Note { get; set; }        
        public Difficulty Difficulty { get; set; }
        public string Description { get; set; }
        public string Directions { get; set; }
        public byte[] Image { get; set; }
        public int PrepTime { get; set; }
        public int CookTime { get; set; }
        public int Servings { get; set; }
        public string Source { get; set; }
        public string Url { get; set; }
    }
}
