using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Customers
    {
        public Customers()
        {
            Addresses = new HashSet<Addresses>();
            Cart = new HashSet<Cart>();
            Orders = new HashSet<Orders>();
            Reviews = new HashSet<Reviews>();
        }

        public int CustId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public decimal? Phone { get; set; }
        public DateTime Dob { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<Addresses> Addresses { get; set; }
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
