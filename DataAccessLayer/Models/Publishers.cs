using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Publishers
    {
        public Publishers()
        {
            Books = new HashSet<Books>();
        }

        public int PublisherId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
