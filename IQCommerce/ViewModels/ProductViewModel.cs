using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IQCommerce.Models;

namespace IQCommerce.ViewModels
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public string Brand { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        [Required]
        public decimal Price { get; set; }
        public bool? MainPage { get; set; }
        public string Picture { get; set; }

        public static explicit operator ProductViewModel(List<Product> v)
        {
            throw new NotImplementedException();
        }

        public ProductViewModel(Product product)
        {
            ProductId = product.ProductId;
            ProductName = product.ProductName;
            Brand = product.Brand;
            Description = product.Description;
            Price = product.Price;
            CategoryId = product.CategoryId;
            Picture = product.Picture;
        }

        public ProductViewModel()
        {

        }
    }
}