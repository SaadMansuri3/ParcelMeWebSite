using System;
using System.Collections.Generic;

#nullable disable

namespace Data
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}
