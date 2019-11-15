﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Appliances.Models
{
    public class Product
    {
        [Key]
        public int? Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Image { get; set; }
        public string Price { get; set; }
        public string Description { get; set; }
        
    }
}
