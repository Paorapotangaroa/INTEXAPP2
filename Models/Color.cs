using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class Color
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public string Value { get; set; }
        public int? Colorid { get; set; }
    }
}
