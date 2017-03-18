using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class GarageController : Controller
    {
        // GET: Garage
        public ActionResult CarsList()
        {
            var factory = new GarageFactory();
            var viewModel = new ViewModels.Garage.CarsListViewModel(factory.Cars);

            return View(viewModel);
        }
    }
}