using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class Inventory
    {
        [Key]
        [JsonPropertyName("inventory_id")]
        public int InventoryId { get; set; }

        [Required]
        [ForeignKey("Product")]
        [JsonPropertyName("product_id")]
        public int ProductId { get; set; }
        public Product? Product { get; set; } 

        [Required]
        [ForeignKey("Warehouse")]
        [JsonPropertyName("warehouse_id")]
        public int WarehouseId { get; set; }
        public Warehouse? Warehouse { get; set; }

        [Required]
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
