using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CRUD_BIBLIOTECA.Models
{
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AutorID { get; set; }

        [Required(ErrorMessage = "El nombre del autor es obligatorio.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener entre 2 y 100 caracteres.")]
        [RegularExpression(@"^[a-zA-ZÀ-ÿ\s]+$", ErrorMessage = "Solo se permiten letras y espacios.")]
        [UniqueAutor(ErrorMessage = "⚠️ Ya existe un autor con este nombre.")]
        public string Nombre { get; set; }

        // Validador personalizado
        public class UniqueAutorAttribute : ValidationAttribute
        {
            protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            {
                var db = new BibliotecaContext();
                var nombreAutor = value as string;

                if (db.Autores.Any(a => a.Nombre == nombreAutor))
                {
                    return new ValidationResult("⚠️ Ya existe un autor con este nombre.");
                }

                return ValidationResult.Success;
            }
        }

        public virtual ICollection<Libro> Libros { get; set; } // Relación con Libros
    }
}
