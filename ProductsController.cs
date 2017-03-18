using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult MyProductView(string searchString)
        {
            var factory = new GarageFactory();
            IQueryable<Car> cars = factory.Cars.OrderBy(c => c.Model);
            if (searchString != null)
            {
                cars = cars.Where(c => c.Model.Contains(searchString));
            }

            var products = cars.Take(10).ToList();

            return View(products);
        }

        //public ActionResult MyProductView()
        //{
        //    var factory = new GarageFactory();
        //    var products = factory.Cars.ToList();

        //    return View(products);
        //}

        public ActionResult ProductDetails(int id)
        {
            var factory = new GarageFactory();
            var foundProduct = factory.Cars.Where(p => p.ID == id).FirstOrDefault();

            return View(foundProduct);
        }

    }
}