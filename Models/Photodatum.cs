using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class Photodatum
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public string Description { get; set; }
        public string Filename { get; set; }
        public int? Photodataid { get; set; }
        public DateTime? Date { get; set; }
        public string Url { get; set; }
    }
}
