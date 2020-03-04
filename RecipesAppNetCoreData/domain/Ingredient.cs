using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.domain
{
    /// <summary>
    /// Ingredient data model
    /// </summary>
    public class Ingredient
    {
        public long Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public UnitOfMeasure Uom { get; set; }
        public Recipe Recipe { get; set; }
    }
}
