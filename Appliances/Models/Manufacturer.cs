using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Models
{
    public class Manufacturer
    {
        [Key]
        public int? ProizvoditelId { get; set; }
        public string ProizvoditelName { get; set; }
        public List<Product> TovarsList { get; set; }
    }
}
