using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
namespace INTEXAPP2.Models
{
    public partial class ArtifactkomaushimregisterBurialmain
    {
        [Key]
        [Required]
        public long MainArtifactkomaushimregisterid { get; set; }
        public long MainBurialmainid { get; set; }
    }
}
