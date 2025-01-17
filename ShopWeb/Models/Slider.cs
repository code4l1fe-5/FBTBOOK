﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWeb.Models
{
    [Table("Sliders")]
    public class Slider
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Link { get; set; }
        public string Img { get; set; }
        public string Orders { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updatee_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int Status { get; set; }
    }
}