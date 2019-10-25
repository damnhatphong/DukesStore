using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Categories
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }

        [Display(Name="CategoryID")]
        public int CategoryId { get; set; }
        [Display(Name="Category Name")]
        public string CategoryName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
