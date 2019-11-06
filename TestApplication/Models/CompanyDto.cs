using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class CompanyDto 
    {
        public string INN { get; set; }
        public string Name { get; set; }
        public ICollection<DeliveryDto> Delivery { get; set; }
    }
}