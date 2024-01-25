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

            // Configuração da relação um-para-muitos entre Pessoa e Telefone
            modelBuilder.Entity<Pessoa>()
                .HasMany(p => p.Telefones) // Pessoa tem muitos Telefones
                .WithOne(t => t.Pessoa)    // Telefone tem uma Pessoa
                .HasForeignKey(t => t.PessoaId); // Com uma chave estrangeira PessoaId em Telefone
               // .OnDelete(DeleteBehavior.Cascade); // Configura o comportamento de exclusão em cascata
        }

    }
}
