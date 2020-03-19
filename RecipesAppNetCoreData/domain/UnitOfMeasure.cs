using System;
using System.Collections.Generic;
using System.Text;

namespace RecipesAppNetCoreData.domain
{
    /// <summary>
    /// Unit Of Measure data model
    /// </summary>
    public class UnitOfMeasure
    {
        public long Id { get; set; }
        public string Description { get; set; }

        public UnitOfMeasure() { }

        public UnitOfMeasure(long Id, string Description)
        {
            this.Id = Id;
            this.Description = Description;
        }
    }
}
