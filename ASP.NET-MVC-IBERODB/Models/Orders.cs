using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [JsonPropertyName("order_id")]
        public int OrderId { get; set; }

        [Required]
        [ForeignKey("Customer")]
        [JsonPropertyName("customer_id")]
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; } 

        [Required]
        [ForeignKey("Salesman")]
        [JsonPropertyName("salesman_id")]
        public int? SalesmanId { get; set; } 
        public Employee? Salesman { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [JsonPropertyName("order_date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("status")]
        public string Status { get; set; }

        public List<OrderItem>? OrderItems { get; set; }
    }
}
