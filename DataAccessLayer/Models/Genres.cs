using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Genres
    {
        public Genres()
        {
            Books = new HashSet<Books>();
        }

        public int GenreId { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
