using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace CustomerService.Models
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string Servicetype { get; set; }
        public int CustomerId { get; set; }
        [JsonIgnore]
        public Customer Customer { get; set; }
    }
}
