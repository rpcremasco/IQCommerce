using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQCommerce.Models;
using System.Data.Entity;
using IQCommerce.ViewModels;


namespace IQCommerce.Controllers
{
    public class ShopController : Controller
    {

        private ApplicationDbContext _context;

        public ShopController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Shop
        public ActionResult Index()
        {
            var products = _context.Products.Include(c => c.ProductCategory).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var products = _context.Products.Include(c => c.ProductCategory).SingleOrDefault(x => x.ProductId == id);
            return View(products);
        }

        public ActionResult AddToCart(int id, int qty = 0)
        {

                ICollection<CartViewModel> cart = Session["cart"] as List<CartViewModel> ?? new List<CartViewModel>();

            if (id != -1 && qty != -1)
            {
                //ICollection<CartViewModel> cartVM = new List<CartViewModel>();

                System.Diagnostics.Debug.WriteLine(value: "raphael");


                Product product = _context.Products.Find(id);

                // Check if the product is already in cart
                var productInCart = cart.FirstOrDefault(x => x.ProductId == id);

                // If not, add new
                if (productInCart == null)
                {
                    //cartVM = cart;
                    cart.Add(new CartViewModel()
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        Quantity = 1,
                        Price = product.Price,
                        Picture = product.Picture
                    });
                }
                else
                {
                    // If it is, increment
                    var prod = cart.SingleOrDefault(x => x.ProductId == id);
                    if (qty > 0)
                    {
                        prod.Quantity = prod.Quantity + qty;
                    }
                    else
                    {
                        prod.Quantity++;
                    }
                    prod.Price = productInCart.Price * prod.Quantity;
                }


                // Get total qty and price and add to model

                /* int qty = 0;
                 decimal price = 0m;

                 foreach (var item in cart)
                 {
                     qty += item.Quantity;
                     price += item.Quantity * item.Price;
                 }

                 cartVM.Quantity = qty;
                 cartVM.Price = price;
                 cartVM.Picture = product.Picture;
                 cartVM.ProductName = product.ProductName;*/
                //cartVM.SingleOrDefault(x => x.ProductId == id).Quantity = 10;

                // Save cart back to session
                //cartVM = null;
                Session["cart"] = cart;

            }
            else
            {
                Session.Clear();
                cart = Session["cart"] as List<CartViewModel> ?? new List<CartViewModel>();
            }

            // Return partial view with model
            return PartialView(cart);
        }
    }
}