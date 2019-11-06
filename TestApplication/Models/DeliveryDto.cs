using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApplication.Models
{
    public class DeliveryDto
    {
        public string Number { get; set; }
        public string INN { get; set; }
        public int Сurrency { get; set; }
        public int Sum { get; set; }
        public CompanyDto CompanyDto { get; set; }
    }
}