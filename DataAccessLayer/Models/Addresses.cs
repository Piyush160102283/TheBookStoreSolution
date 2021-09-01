using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Addresses
    {
        public int AddressId { get; set; }
        public int CustId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Landmark { get; set; }
        public string Region { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public decimal Pincode { get; set; }

        public virtual Customers Cust { get; set; }
    }
}
