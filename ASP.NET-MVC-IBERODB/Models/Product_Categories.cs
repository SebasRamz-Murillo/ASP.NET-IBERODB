using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class ProductCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        public List<Product>? Products { get; set; } 
    }
}
