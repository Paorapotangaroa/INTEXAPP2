using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class Teammember
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public string Bio { get; set; }
        public string Membername { get; set; }
    }
}
