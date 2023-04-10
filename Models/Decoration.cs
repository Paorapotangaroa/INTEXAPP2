using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class Decoration
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public int? Decorationid { get; set; }
        public string Value { get; set; }
    }
}
