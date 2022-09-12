using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShopWeb.Models
{
    [Table("Posts")]
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TopicId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Slug { get; set; }
        public string Detail { get; set; }
        [Required]
        public string Metakey { get; set; }
        [Required]
        public string Metadesc { get; set; }
        public string Img { get; set; }
        public int? Created_By { get; set; }
        public DateTime? Created_At { get; set; }
        public int? Updatee_By { get; set; }
        public DateTime? Updated_At { get; set; }
        public int Status { get; set; }
    }
}