using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class OrderItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("order_id")]
        public int OrderId { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        [JsonPropertyName("item_id")]
        public int ItemId { get; set; } 

        [Required]
        [ForeignKey("Product")]
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        public Product? Product { get; set; } 

        [Required]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(8, 2)")]
        [JsonPropertyName("unit_price")]
        public decimal UnitPrice { get; set; }

        [ForeignKey("Order")] 
        public Order? Order { get; set; }


    }
}
