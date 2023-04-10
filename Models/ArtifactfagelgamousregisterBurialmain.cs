using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class ArtifactfagelgamousregisterBurialmain
    {
        [Key]
        [Required]
        public long MainArtifactfagelgamousregisterid { get; set; }
        public long MainBurialmainid { get; set; }
    }
}
