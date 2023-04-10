using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class DimensionTextile
    {
        [Key]
        [Required]
        public long MainDimensionid { get; set; }
        public long MainTextileid { get; set; }
    }
}
