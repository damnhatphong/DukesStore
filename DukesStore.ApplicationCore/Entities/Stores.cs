using System;
using System.Collections.Generic;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Stores
    {
        public Stores()
        {
            Orders = new HashSet<Orders>();
            Staffs = new HashSet<Staffs>();
            Stocks = new HashSet<Stocks>();
        }

        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Ward { get; set; }
        public string District { get; set; }
        public string ZipCode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Staffs> Staffs { get; set; }
        public virtual ICollection<Stocks> Stocks { get; set; }
    }
}
