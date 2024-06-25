﻿



namespace WebApplication2.Models
{
    public class Customer
    {
        public int Id { get; set;  }
        public required string CustomerCode { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public int Phone { get; set; }
        public bool IsActive { get; set; }

    }
}
