using System;
using System.Collections.Generic;

namespace PurchaseBookApp.Models
{
    public partial class User
    {
        public User()
        {
            Books = new HashSet<Book>();
            Payments = new HashSet<Payment>();
        }

        public long UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public decimal? PhoneNumber { get; set; }

        public virtual ICollection<Book> Books { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
