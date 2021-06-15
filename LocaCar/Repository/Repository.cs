using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
       public DbSet<Model.Cliente> Clientes { get; set; }
        public DbSet<Model.Veiculo> Veiculos { get; set; }
        public DbSet<Model.Locacao> Locacoes { set; get; }
        public DbSet<Model.LocacaoVeiculo> LocacaoVeiculo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=;database=locacar;",
                new MySqlServerVersion("8.0.22")
            );

        }

    }
}


