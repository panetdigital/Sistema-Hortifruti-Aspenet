using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NovoProjetoFrutas.Model;

namespace NovoProjetoFrutas.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adicionando dados de semente
            modelBuilder.Entity<Produto>().HasData(
                new Produto

                {
                    Id = 1,
                    Cod = "192",
                    CodItem = "1922",
                    Nome = "Abóbora Moranga",
                    Preco = 5,
                    PrecoPromo = 4,
                    Grupo = "legume",
                    EstoqueDisponivel = 100,
                    Link = "\"https:\\/\\/www.nagumo.com.br\\/sao-paulo-lj17-pires-do-rio-jardim-lideranca-avenida-pires-do-rio\\/produto\\/abobora-------------------------moranga",
                    Imagem = "\"https:\\/\\/www.nagumo.com.br\\/sao-paulo-lj17-pires-do-rio-jardim-lideranca-avenida-pires-do-rio\\/produto\\/abobora-------------------------moranga"
                }
            );
        }
        public DbSet<NovoProjetoFrutas.Model.Produto> Produto { get; set; } = default!;
    }
}
