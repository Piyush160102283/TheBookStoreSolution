using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Reviews
    {
        public int ReviewId { get; set; }
        public int CustId { get; set; }
        public int BookId { get; set; }
        public int Rating { get; set; }
        public string Comments { get; set; }
        public int OrderId { get; set; }

        public virtual Books Book { get; set; }
        public virtual Customers Cust { get; set; }
        public virtual Orders Order { get; set; }
    }
}
