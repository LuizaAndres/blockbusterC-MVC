using Microsoft.EntityFrameworkCore;
using Models;

namespace Repositories
{
    public class Context : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacoes { get; set; }
        public DbSet<FilmeLocacao> FilmeLocacao { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=blockbuster.c4noexyrvpg3.us-east-1.rds.amazonaws.com;User Id=admin;Password=Odonto001;Database=blockbuster");
    }
}