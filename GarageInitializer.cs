using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MVCExample.Models
{
    public class GarageInitializer : DropCreateDatabaseIfModelChanges<GarageFactory>
    {
        protected override void Seed(GarageFactory context)
        {
            context.Cars.Add(new Car() { Model = "Rabbit", Maxspeed = 300 });
            context.Cars.Add(new Car() { Model = "Turtle", Maxspeed = 150 });
        }
    }
}