using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Globalization;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ShowLanguages()
        {
            var viewModel = new ViewModels.Home.ShowLanguagesViewModel(CultureInfo.GetCultures(CultureTypes.SpecificCultures));

            return View(viewModel);
        }

        public ActionResult ComputeProduct(decimal? number1, decimal? number2)
        {
            var viewModel = new ViewModels.Home.ComputeProductViewModel(number1, number2);

            return View(viewModel);
        }
    }
}