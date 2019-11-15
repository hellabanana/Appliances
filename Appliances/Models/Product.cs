using System.ComponentModel.DataAnnotations;

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
        public string Category { get; set; }
        
    }
}
