using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IQCommerce.Models
{
    public class Province
    {
        [Key]
        public int ProvinceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProvinceCode { get; set; }
        [Required]
        public decimal TaxRate { get; set; }
    }
}