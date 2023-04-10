﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace INTEXAPP2.Models
{
    public partial class Dimension
    {
        [Key]
        [Required]
        public long Id { get; set; }
        public string Dimensiontype { get; set; }
        public string Value { get; set; }
        public int? Dimensionid { get; set; }
    }
}
