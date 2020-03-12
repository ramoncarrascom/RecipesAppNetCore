using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.domain
{
    /// <summary>
    /// Recipe-Category relationship
    /// </summary>
    public class RecipeCategory
    {
        public long RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
