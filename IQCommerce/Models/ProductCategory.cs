using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IQCommerce.Models
{
    public class ProductCategory
    {
        [Key]
        public int CategoryId { get; set; }
        public string Name { get; set; }
    }
}