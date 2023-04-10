using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class StructureTextile
    {
        [Key]
        [Required]
        public long MainStructureid { get; set; }
        public long MainTextileid { get; set; }
    }
}
