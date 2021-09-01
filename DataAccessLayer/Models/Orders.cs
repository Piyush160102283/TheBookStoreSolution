using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Reviews = new HashSet<Reviews>();
        }

        public int OrderId { get; set; }
        public int CustId { get; set; }
        public int BookId { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAddress { get; set; }
        public string PaymentMode { get; set; }
        public int TotalAmount { get; set; }

        public virtual Books Book { get; set; }
        public virtual Customers Cust { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
