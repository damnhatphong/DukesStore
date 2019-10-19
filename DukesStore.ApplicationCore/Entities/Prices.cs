using System;
using System.Collections.Generic;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Prices
    {
        public Prices()
        {
            Products = new HashSet<Products>();
        }

        public int PriceId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        //public string CurrencyUnit { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        
        public int CurrencyId { get; set; }
        public Currency Currency { get; set; }
        
        public virtual ICollection<Products> Products { get; set; }
    }
}
