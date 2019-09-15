using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class ProductViewModel
    {
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ProductType { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        [Range(0, (double)decimal.MaxValue)]
        public decimal Price { get; set; }
        [Required]
        [Range(0, int.MaxValue)]
        public int Stock { get; set; }
    }
}
