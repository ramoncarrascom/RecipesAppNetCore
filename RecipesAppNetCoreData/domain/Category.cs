using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.domain
{
    /// <summary>
    /// Category data model
    /// </summary>
    public class Category
    {
        public long Id { get; set; }
        public List<Recipe> Recipes { get; set; }
        public string Description { get; set; }
    }
}
