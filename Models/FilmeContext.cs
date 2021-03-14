using Microsoft.EntityFrameworkCore;
namespace FilmesCRUDRazor.Models
{
    internal class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> options)
            : base(options)
            {
                //Default
            }
            public DbSet<Filme> Filme { get; set; }
    }
}