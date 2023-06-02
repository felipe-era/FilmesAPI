using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
    public class FilmeContext : DbContext //add o DbContext para usar o Entity
    {

        public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)//ctor
        {
            
        }

        //propriedades para acesso aos filmes da base
        public DbSet<Filme> Filmes { get; set; }

    }
}
