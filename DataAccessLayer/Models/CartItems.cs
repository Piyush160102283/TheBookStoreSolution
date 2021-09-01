using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class CartItems
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public int BookId { get; set; }
        public int Quantity { get; set; }
        public int TotalAmount { get; set; }

        public virtual Books Book { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
