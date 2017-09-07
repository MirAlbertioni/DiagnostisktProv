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
                var tv = new ProductCategory { Name = "TV" };
                var dvd = new ProductCategory { Name = "DVD" };
                var vhs = new ProductCategory { Name = "VHS" };
            }
        }
    }
}
