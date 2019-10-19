using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Currency
    {
        public Currency()
        {
            Prices = new HashSet<Prices>();
        }
        public int CurrencyId { get; set; }
        public string CurrencyUnit { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Prices> Prices { get; set; }   
    }
}
