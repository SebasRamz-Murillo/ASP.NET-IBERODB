using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP.NET_MVC_IBERODB.Models
{
    public class Location
    {
        [Key]
        [JsonPropertyName("location_id")]
        public int LocationId { get; set; }

        [Required]
        [StringLength(255)]
        [JsonPropertyName("address")]
        public string Address { get; set; }

        [StringLength(20)]
        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        [StringLength(50)]
        [JsonPropertyName("city")]
        public string City { get; set; }

        [StringLength(50)]
        [JsonPropertyName("state")]
        public string State { get; set; }

        [ForeignKey("Country")]
        [JsonPropertyName("country_id")]
        public int? CountryId { get; set; }
        public Country? Country { get; set; } 
    }
}
