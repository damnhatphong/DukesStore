using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Products
    {
        public Products()
        {
            OrderItems = new HashSet<OrderItems>();
            Stocks = new HashSet<Stocks>();
        }
        [Display(Name="Product ID")]
        public int ProductId { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Brand ID")]
        public int BrandId { get; set; }
        [Display(Name = "Category ID")]
        public int CategoryId { get; set; }
        [Display(Name = "Model Year")]
        public short ModelYear { get; set; }
        [Display(Name = "Price ID")]
        public int PriceId { get; set; }
        [Display(Name="Description")]
        public string Description { get; set; }

        public virtual Brands Brand { get; set; }
        public virtual Categories Category { get; set; }
        public virtual Prices Price { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
        public virtual ICollection<Stocks> Stocks { get; set; }
    }
}
