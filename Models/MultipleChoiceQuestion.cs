﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Midterm.Models
{
    public class MultipleChoiceQuestion : TestQuestion
    {
        [Required]
        public override string Answer { get; set; }
        public IList<string> Choices { get; set; }
    }
}
