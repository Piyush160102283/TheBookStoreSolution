﻿using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models
{
    public partial class Admins
    {
        public int AdminId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public decimal? Phone { get; set; }
        public DateTime? Dob { get; set; }
        public int? Age { get; set; }
    }
}
