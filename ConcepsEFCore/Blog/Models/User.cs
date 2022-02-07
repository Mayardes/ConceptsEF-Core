using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Name", TypeName = "VARCHAR")]
        public string Name { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Email", TypeName = "VARCHAR")]
        public string Email { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("PasswordHash", TypeName = "VARCHAR")]
        public string PasswordHash { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Image", TypeName = "VARCHAR")]
        public string Image { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Slug", TypeName = "VARCHAR")]
        public string Slug { get; set; }

        [Required]
        [MaxLength(80, ErrorMessage = "")]
        [MinLength(1)]
        [Column("Bio", TypeName = "VARCHAR")]
        public string Bio { get; set; }
    }
}
