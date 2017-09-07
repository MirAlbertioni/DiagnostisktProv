using DiagnostiskProv.Data;
using DiagnostiskProv.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostiskProv.Services
{
    public class CategoryService : Controller
    {
        private readonly ApplicationDbContext _context;
        private IHostingEnvironment _env;
        private readonly ILogger<CategoryService> _logger;

        public CategoryService(ApplicationDbContext context, IHostingEnvironment env, ILogger<CategoryService> logger)
        {
            _context = context;
            _env = env;
            _logger = logger;
        }

        public SelectList GetSelectList(Product product)
        {
            return new SelectList(_context.Category, "CategoryId", "Name", product.CategoryId);
        }
    }
}
