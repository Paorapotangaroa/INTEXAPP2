using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class AnalysisTextile
    {
        [Key]
        [Required]
        public long MainAnalysisid { get; set; }
        public long MainTextileid { get; set; }
    }
}
