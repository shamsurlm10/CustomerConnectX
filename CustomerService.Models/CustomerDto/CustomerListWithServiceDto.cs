using CustomerService.Models.ServiceDto;
namespace CustomerService.Models.CustomerDto
{
    public class CustomerListWithServiceDto
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public List<ServiceListDto>ServicesForCustomer { get; set; }
    }
}
