using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class TextilefunctionTextile
    {
        [Key]
        [Required]
        public long MainTextilefunctionid { get; set; }
        public long MainTextileid { get; set; }
    }
}
