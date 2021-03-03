using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace supercar.Models
{
    public class Customer
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Customer Name")]
        public string custname { get; set; }
        [Required]
        [Display(Name = "Customer Address")]
        public string address { get; set; }
        [Required]
        [Display(Name ="Mobile Number")]
        public int mobile { get; set; }
    }
}
