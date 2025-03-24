using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_BIBLIOTECA.Models
{
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LibroID { get; set; }

        [Required]
        [StringLength(255)]
        [Index(IsUnique = true)] // Restringe que los títulos sean únicos
        public string Titulo { get; set; }

        [Required]
        public int AutorID { get; set; }

        [ForeignKey("AutorID")]
        public virtual Autor Autor { get; set; }
    }
}
