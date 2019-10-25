using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Customers
    {
        public Customers()
        {
            Orders = new HashSet<Orders>();
        }

        [Display(Name="CustomerID")]
        public int CustomerId { get; set; }

        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }


        [Display(Name = "Street")]
        public string Street { get; set; }


        [Display(Name = "City")]
        public string City { get; set; }


        [Display(Name = "Ward")]
        public string Ward { get; set; }


        [Display(Name = "District")]
        public string District { get; set; }


        [Display(Name = "ZipCode")]
        public string ZipCode { get; set; }

        public virtual ICollection<Orders> Orders { get; set; }
    }
}
