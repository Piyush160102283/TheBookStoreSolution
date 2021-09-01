using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Books
    {
        public Books()
        {
            CartItems = new HashSet<CartItems>();
            Orders = new HashSet<Orders>();
            Reviews = new HashSet<Reviews>();
        }

        public int BookId { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
        public int GenreId { get; set; }
        public int? Rating { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public DateTime? PublishDate { get; set; }
        public decimal? Price { get; set; }
        public int? QuantityAvailable { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Genres Genre { get; set; }
        public virtual Publishers Publisher { get; set; }
        public virtual ICollection<CartItems> CartItems { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}
