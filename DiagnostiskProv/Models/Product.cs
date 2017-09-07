using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostiskProv.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Range(minimum: 5, maximum: 1000, ErrorMessage = "Must be between 5 and 1000")]
        public decimal Price { get; set; }
    }
}
