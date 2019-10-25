using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Brands
    {
        public Brands()
        {
            Products = new HashSet<Products>();
        }
        
        [Display(Name="BrandID")]
        public int BrandId { get; set; }
        [Display(Name="Brand Name")]
        public string BrandName { get; set; }

        public virtual ICollection<Products> Products { get; set; }
    }
}
