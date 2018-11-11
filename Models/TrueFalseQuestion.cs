using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class TrueFalseQuestion : TestQuestion
    {
        [Required]
        [RegularExpression("^(?i)(true|false)$", ErrorMessage = "Must be either 'True' or 'False'")]
        override public string Answer { get; set; }
    }
}
