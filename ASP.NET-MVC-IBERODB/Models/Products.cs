using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("product_name")]
        public string ProductName { get; set; }

        [StringLength(2000)]
        [JsonPropertyName("description")]
        public string? Description { get; set; } 

        [Column(TypeName = "decimal(9, 2)")]
        [JsonPropertyName("standard_cost")]
        public decimal StandardCost { get; set; }

        [Column(TypeName = "decimal(9, 2)")]
        [JsonPropertyName("list_price")]
        public decimal ListPrice { get; set; }

        [Required]
        [ForeignKey("Category")]
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
        public ProductCategory? Category { get; set; }

        public List<OrderItem>? OrderItems { get; set; }
    }
}
