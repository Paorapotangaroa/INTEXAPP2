using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class BurialmainTextile
    {
        [Key]
        [Required]
        public long MainBurialmainid { get; set; }
        public long MainTextileid { get; set; }
    }
}
