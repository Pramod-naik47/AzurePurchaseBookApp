using System;
using System.Collections.Generic;

namespace PurchaseBookApp.Models
{
    public partial class VBookPayment
    {
        public long BookId { get; set; }
        public string BookTitle { get; set; }
        public string Category { get; set; }
        public decimal? Price { get; set; }
        public string Content { get; set; }
        public bool? Active { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? PublishDate { get; set; }
        public string Publisher { get; set; }
        public long? UserId { get; set; }
        public long PaymentId { get; set; }
        public DateTime? PaymentDate { get; set; }
    }
}
