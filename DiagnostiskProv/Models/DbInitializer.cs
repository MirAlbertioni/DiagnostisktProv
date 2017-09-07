using DiagnostiskProv.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostiskProv.Models
{
    public static class DbInitializer
    {
        public static void Initializer(ApplicationDbContext context, IHostingEnvironment env, IApplicationBuilder app)
        {
            if(context.Products.ToList().Count == 0)
            {
                var tv = new Category { Name = "TV" };
                var dvd = new Category { Name = "DVD" };
                var vhs = new Category { Name = "VHS" };

                var tvPhilips = new Product { Name = "Philips", Price = 999, Category = tv };
                var dvdSamsung = new Product { Name = "Samsung", Price = 999, Category = dvd };

                context.AddRange(tvPhilips, dvdSamsung, tv, dvd, vhs);
                context.SaveChanges();
            }
        }
    }
}
