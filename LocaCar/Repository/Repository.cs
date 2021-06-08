using System.Collections.Generic;
using Model;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
       public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Locacao> Locacoes { set; get; }
        public DbSet<LocacaoVeiculo> LocacaoVeiculo { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseMySql(
                "server=localhost;user=root;password=;database=locacar;",
                new MySqlServerVersion("8.0.22")
            );

        }

    }
}


