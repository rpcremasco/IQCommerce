using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IQCommerce.Models
{
    public class OrderItems
    {
        [Key]
        public int OrderItemsId { get; set; }
        public Order Order { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Product Product { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int ItemQuatity { get; set; }
    }


}