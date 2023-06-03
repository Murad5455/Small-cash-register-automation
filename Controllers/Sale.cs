using CoreTask3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTask3.Controllers
{
    public class Sale : Controller
    {
        private  Context _dbContext;

        public Sale(Context dbContext)
        {
            _dbContext = dbContext;
        }
        Product p = new Product();
        public IActionResult Index()
        {
          

            var products = _dbContext.Products.ToList();
            return View(products);
        }

      //  [HttpGet]
        public IActionResult Buy(int id)
        {
           
            var product = _dbContext.Products.Find(id);

            DateTime currentTime = DateTime.Now;

            ViewData["CurrentTime"] = currentTime;


            return View(product);
        }
       
        public IActionResult Cart()
        {

            var products = _dbContext.Products.ToList();

            return View(products);
        }
        public IActionResult Cash()
        {
            var products = _dbContext.Products.ToList();

            return View(products);
        }


            //        [HttpPost]
            //        public IActionResult Buy(Product product)
            //        {
            //            Çek oluşturma ve kaydetme işlemleri
            //           var check = new Product
            //           {
            //               Number = "123456",
            //               Amount = product.Total,
            //                // Date = DateTime.Now
            //            };

            //            _dbContext.Checks.Add(check);
            //            _dbContext.SaveChanges();

            //            return RedirectToAction("Buy");
            //        }

            //        public IActionResult Checks()
            //        {
            //            var checks = _dbContext.Checks.ToList();
            //            return View(checks);
            //        }
        }
}
