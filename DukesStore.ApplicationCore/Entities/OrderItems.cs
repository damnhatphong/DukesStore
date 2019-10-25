using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class OrderItems
    {
     
        [Display(Name="OrderID")]
        public int OrderId { get; set; }

        [Display(Name="ProductID")]
        public int ProductId { get; set; }
        
        [Display(Name="Quantity")]
        public int Quantity { get; set; }

        [Display(Name="Total Price")]
        public decimal TotalPrice { get; set; }

        [Display(Name="Discount")]
        public decimal Discount { get; set; }

        public virtual Orders Order { get; set; }
        public virtual Products Product { get; set; }
    }
}
