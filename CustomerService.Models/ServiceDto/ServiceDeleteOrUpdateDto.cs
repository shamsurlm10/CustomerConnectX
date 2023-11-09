using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Models.ServiceDto
{
    public class ServiceDeleteOrUpdateDto
    {
        public int ServiceId { get; set; }
        public string Servicetype { get; set; }
        public int CustomerId { get; set; }
    }
}
