using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("Category")]
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1, ErrorMessage = "")]
        [Column("Name", TypeName = "VARCHAR")]
        public string Name { get; set; }

        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1, ErrorMessage = "")]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }
    }
}
