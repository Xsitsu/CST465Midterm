using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class LongAnswerQuestion : TestQuestion
    {
        [Required]
        public override string Answer { get; set; }
    }
}
