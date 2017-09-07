using DiagnostiskProv.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostiskProv.Models
{
    public static class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context)
        {
            if(context.Products.ToList().Count == 0)
            {
                var tv = new Category { Name = "TV" };
                var dvd = new Category { Name = "DVD" };
                var vhs = new Category { Name = "VHS" };

                var tvPhilips = new Product { Name = "Philips", Price = 999, Category = tv };

                context.AddRange(tvPhilips, tv, dvd, vhs);
                context.SaveChanges();
            }
        }
    }
}
