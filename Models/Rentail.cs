using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace supercar.Models
{
    public class Rentail
    {
        [Key]
        public int id { get; set; }
        public string carid { get; set; }
        public int custid { get; set; }
        public int fee { get; set; }
        public DateTime sdate { get; set; }
        public DateTime edate { get; set; }
    }
}
