using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerService.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }
        public string Servicetype { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
