using desafioLar.Models;
using Microsoft.EntityFrameworkCore;

namespace desafioLar.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Telefone> Telefones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Telefones)
                .WithOne(t => t.Pessoa)
                .HasForeignKey(t => t.PessoaId);
        }
    }
}
