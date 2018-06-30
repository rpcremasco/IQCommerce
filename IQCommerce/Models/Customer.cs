using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IQCommerce.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please provide the Name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public DateTime? Birthdate { get; set; }
        public bool? IsSubscribedToNewsLetter { get; set; }
        [Required]
        public string  Address { get; set; }
        [Required]
        [RegularExpression("^[A-Z]{2}[0-9]{1}-[0-9]{1}[A-Z]{1}[0-9]{1}$", ErrorMessage = "Invalid ZipCode")]
        public string ZipCode { get; set; }
        public Province Province { get; set; }
        [Required]
        public int ProvinceId { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get;  set;}
        [Required]
        public string UserName { get; set; }

    }
}