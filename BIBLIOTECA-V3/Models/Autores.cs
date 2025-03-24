using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_BIBLIOTECA.Models
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutorID { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        public virtual ICollection<Libro> Libros { get; set; } // Relación con Libros
    }
}
