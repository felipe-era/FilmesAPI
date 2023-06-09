using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data;

//FilmeContext = classe de cotexto para acesso ao banco
//como se conecta e como acessa!?
//Abstrai a lógica de acesso ao banco de dados, reduz o esforço para acessar o BD
public class FilmeContext : DbContext //add o DbContext para usar o Entity
{
    public FilmeContext(DbContextOptions<FilmeContext> opts) : base(opts)//ctor
    {
        
    }

    //propriedades para acesso aos filmes/cinemas da base
    public DbSet<Filme> Filmes { get; set; }
    public DbSet<Cinema> Cinemas { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Sessao> Sessoes { get; set; }
}
}
