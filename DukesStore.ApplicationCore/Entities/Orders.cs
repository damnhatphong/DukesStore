using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DukesStore.ApplicationCore.Entities
{
    public partial class Orders
    {
        public Orders()
        {
            OrderItems = new HashSet<OrderItems>();
        }

        [Display(Name="OrderID")]
        public int OrderId { get; set; }

        [Display(Name = "CustomerID")]
        public int? CustomerId { get; set; }

        [Display(Name = "Order Status")]
        public byte OrderStatus { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }


        [Display(Name = "Required Date")]
        public DateTime RequiredDate { get; set; }


        [Display(Name = "Required Date")]
        public DateTime? ShippedDate { get; set; }


        [Display(Name = "StoreID")]
        public int StoreId { get; set; }


        [Display(Name = "StaffID")]
        public int StaffId { get; set; }

        public virtual Customers Customer { get; set; }
        public virtual Staffs Staff { get; set; }
        public virtual Stores Store { get; set; }
        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
