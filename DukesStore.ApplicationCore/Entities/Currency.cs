using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Currency
    {
        public Currency()
        {
            Prices = new HashSet<Prices>();
        }
        [Display(Name="CurrencyID")]
        public int CurrencyId { get; set; }

        [Display(Name = "Currency Unit")]
        public string CurrencyUnit { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedDate { get; set; }
        public virtual ICollection<Prices> Prices { get; set; }   
    }
}
