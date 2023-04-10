using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class ColorTextile
    {
        [Key]
        [Required]
        public long MainColorid { get; set; }
        public long MainTextileid { get; set; }
    }
}
