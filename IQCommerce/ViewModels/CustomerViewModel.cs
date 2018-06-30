using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQCommerce.Models;
using System.ComponentModel.DataAnnotations;

namespace IQCommerce.ViewModels
{
    public class CustomerViewModel
    {
        public IEnumerable<Province> Provinces { get; set; }

        public int? CustomerId { get; set; }
        [Required(ErrorMessage = "Please provide the Name")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
        public bool? IsSubscribedToNewsLetter { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        [RegularExpression("^[A-Z]{2}[0-9]{1}-[0-9]{1}[A-Z]{1}[0-9]{1}$", ErrorMessage = "Invalid ZipCode")]
        public string ZipCode { get; set; }
        [Required]
        public int ProvinceId { get; set; }
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Required]
        public string UserName { get; set; }

        public CustomerViewModel(Customer customer)
        {
            CustomerId = customer.CustomerId;
            Name = customer.Name;
            Birthdate = customer.Birthdate;
            IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            Address = customer.Address;
            ZipCode = customer.ZipCode;
            ProvinceId = customer.ProvinceId;
            EmailAddress = customer.EmailAddress;
            UserName = customer.UserName;

        }

        public CustomerViewModel()
        {
            CustomerId = 0;
        }
    }
}