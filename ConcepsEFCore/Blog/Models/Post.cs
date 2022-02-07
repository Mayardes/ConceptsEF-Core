using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Post")]
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Title", TypeName = "VARCHAR")]
        public string Title { get; set; }

        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Summary", TypeName = "VARCHAR")]
        public string Summary { get; set; }

        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Body", TypeName = "VARCHAR")]
        public string Body { get; set; }

        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }

        [Column("CreateDate", TypeName = "DATETIME")]
        public DateTime CreateDate { get; set; }

        [Column("LastUpdateDate", TypeName = "DATETIME")]
        public DateTime LastUpdateDate { get; set; }


        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }


        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
