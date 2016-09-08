using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CustomerService.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Customer code is required")]
        [RegularExpression("^[A-Z]{1,1}[0-9]{3,3}$")]
        public string CustomerName { get; set; }
        [Required]
        public string CustomerCode { get; set; }
    }
}