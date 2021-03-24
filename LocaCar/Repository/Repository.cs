using System.Collections.Generic;
using Model;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class Context : DbContext
    {
        public  DbSet<Cliente> Clientes { set; get; }
        public  DbSet<VeiculoPesado> VeiculosPesado { set; get; }
        public  DbSet<VeiculoLeve> VeiculosLeve { set; get; }
        public  DbSet<Locacao> Locacoes { set; get; }
        public  DbSet<LocacaoVeiculoPesado> LocacoesVeiculosPesado { set; get; }
        public  DbSet<LocacaoVeiculoLeve> LocacoesVeiculosLeve { set; get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql("Server=localhost;User Id=root;Database=locacar");

    }
}