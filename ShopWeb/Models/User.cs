﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWeb.Models
{
    [Table("Users")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Roles { get; set; }
        [Required]
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updatee_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int Status { get; set; }
    }
}