using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IQCommerce.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public string Brand { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public ProductCategory ProductCategory { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public bool? MainPage { get; set; }
        public string Picture { get; set; }

    }
}