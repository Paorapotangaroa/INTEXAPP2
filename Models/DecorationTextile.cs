using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class DecorationTextile
    {
        [Key]
        [Required]
        public long MainDecorationid { get; set; }
        public long MainTextileid { get; set; }
    }
}
