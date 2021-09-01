using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Cart
    {
        public Cart()
        {
            CartItems = new HashSet<CartItems>();
        }

        public int CartId { get; set; }
        public int CustId { get; set; }

        public virtual Customers Cust { get; set; }
        public virtual ICollection<CartItems> CartItems { get; set; }
    }
}
