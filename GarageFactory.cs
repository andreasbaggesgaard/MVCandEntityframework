using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MVCExample.Models
{
    public class GarageFactory : DbContext
    {
        public DbSet<Car> Cars { get; set; }

        public GarageFactory()
        {
            Database.SetInitializer(new GarageInitializer());
        }
    }
}