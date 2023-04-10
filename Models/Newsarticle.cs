using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class Newsarticle
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Urltoimage { get; set; }
        public string Url { get; set; }
    }
}
