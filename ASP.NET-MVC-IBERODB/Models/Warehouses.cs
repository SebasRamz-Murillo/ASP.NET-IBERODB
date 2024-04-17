using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class Warehouse
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("warehouse_id")]
        public int WarehouseId { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("warehouse_name")]
        public string WarehouseName { get; set; }

        [StringLength(255)]
        [JsonPropertyName("location")]
        public string? Location { get; set; } 

        public List<Inventory>? Inventories { get; set; } 
    }
}
