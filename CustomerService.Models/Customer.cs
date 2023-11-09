using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<Service> Services { get; set; }
    }
}
