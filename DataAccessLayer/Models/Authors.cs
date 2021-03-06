using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
