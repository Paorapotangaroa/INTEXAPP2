using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class BiologicalC14
    {
        [Key]
        [Required]
        public long MainBiologicalid { get; set; }
        public long MainC14id { get; set; }
    }
}
