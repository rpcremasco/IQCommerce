using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IQCommerce.Models;

namespace IQCommerce.ViewModels
{
    public class OrderViewModel
    {
        public IEnumerable<OrderItems> OrderItems { get; set; }

        public int? OrderId { get; set; }
        public int InvoiceNumber { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [Required]
        public decimal PriceSum { get; set; }
        [Required]
        public decimal TotalPrice { get; set; }
        public char? PaymentStatus { get; set; }

        public OrderViewModel(Order order)
        {
            OrderId = order.OrderId;
            InvoiceNumber = order.InvoiceNumber;
            CustomerId = order.CustomerId;
            PriceSum = OrderItems.Sum(x => x.ItemQuatity * x.Product.Price);
            TotalPrice = PriceSum * 0.75m;
        }
    }
}