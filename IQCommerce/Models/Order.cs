using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IQCommerce.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public int InvoiceNumber { get; set; }
        public Customer Customer { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public decimal PriceSum { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        public char PaymentStatus { get; set; }

    }
}