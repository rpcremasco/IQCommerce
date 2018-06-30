using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IQCommerce.Models;
using IQCommerce.ViewModels;
using System.Data.Entity;

namespace IQCommerce.Controllers
{
    public class HomeController : Controller
    {

        private ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {

            var products = _context.Products.Include(c => c.ProductCategory).ToList();

            return View(products);
        }

        public ActionResult Compras()
        {
            
            return View(_context.Products.Include(c => c.ProductCategory).ToList());
            //return RedirectToRoute("Shop");
        }

        public ViewResult About()
        {
            throw new NotImplementedException();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}