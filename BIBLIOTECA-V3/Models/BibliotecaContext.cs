using System.Collections.Generic;
using System.Data.Entity;

namespace CRUD_BIBLIOTECA.Models
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("BibliotecaContext") { }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }
    }
}
