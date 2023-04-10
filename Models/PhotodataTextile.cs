using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class PhotodataTextile
    {
        [Key]
        [Required]
        public long MainPhotodataid { get; set; }
        public long MainTextileid { get; set; }
    }
}
