using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class YarnmanipulationTextile
    {
        [Key]
        [Required]
        public long MainYarnmanipulationid { get; set; }
        public long MainTextileid { get; set; }
    }
}
