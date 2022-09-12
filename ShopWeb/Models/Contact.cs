using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWeb.Models
{
    [Table("Contacts")]
    public class Contact
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
        public string Tilte { get; set; }
        [Required]
        public string content { get; set; }
        [Required]
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updatee_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int Status { get; set; }
    }
}