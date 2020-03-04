using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.domain
{
    /// <summary>
    /// Note data model
    /// </summary>
    public class Note
    {

        public long Id { get; set; }
        public Recipe Recipe { get; set; }
        public string RecipeNotes { get; set; }

    }
}
