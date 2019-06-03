using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTagHelpers.Models
{
    public class TechTerm
    {
        [Required]
        [Display(Name = "Fagterm")]
        [MinLength(2)]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        [MinLength(10)]
        [Display(Name = "Beskrivelse")]
        public string Description { get; set; }
    }
}
