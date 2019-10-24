using ApiBiblioteca.Entities;
using Microsoft.EntityFrameworkCore;

namespace ApiBiblioteca.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Autor> Autores { get; set; }
    }
}