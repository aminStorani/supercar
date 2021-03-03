using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace supercar.Models
{
    public class Carreg
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Name Of The Product")]
        public string carno { get; set; }
        [Display(Name = "Make")]
        public string make { get; set; }
        [Display(Name = "Model")]
        public string model { get; set; }
        [Required]
        [Display(Name = "Is it Available ?")]
        public string available { get; set; }
    }
}
