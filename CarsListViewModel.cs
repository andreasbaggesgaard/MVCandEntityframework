using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MVCExample.Models;
using System.Data.Entity;
using System.Web.Mvc;

namespace MVCExample.ViewModels.Garage
{
    public class CarsListViewModel
    {
        public CarsListViewModel(DbSet<Car> cars)
        {
            CarsList = cars.Select(c => new SelectListItem() { Text = c.Model });
            FastestCar = cars.OrderByDescending(c => c.Maxspeed).FirstOrDefault();
        }

        public IEnumerable<SelectListItem> CarsList { get; private set; }
        public Car FastestCar { get; set; }
    }
}