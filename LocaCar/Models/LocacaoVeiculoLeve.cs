using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class LocacaoVeiculoLeve
    {
        public string Id { set; get; }
        public int LocacaoId { set; get; }
        public Locacao Locacao { set; get; }
        public int VeiculoLeveId { set; get; }
        public VeiculoLeve VeiculoLeve { set; get; }

        // public static readonly List<LocacaoVeiculoLeve> bancoDeDados = new();

        public LocacaoVeiculoLeve() {
            
        }
        public LocacaoVeiculoLeve(
            Locacao Locacao,
            VeiculoLeve VeiculoLeve
        )
        {
            Context db = new Context();
            this.Locacao = Locacao;
            this.LocacaoId = Locacao.Id;
            this.VeiculoLeve = VeiculoLeve;
            this.VeiculoLeveId = VeiculoLeve.Id;

            db.LocacoesVeiculosLeve.Add(this);
            db.SaveChanges();

        }

        public static IEnumerable<LocacaoVeiculoLeve> GetVeiculos(int LocacaoId)
        {
            Context db = new Context();
            return from veiculo in db.LocacoesVeiculosLeve where veiculo.LocacaoId == LocacaoId select veiculo;
        }

        public static int GetCount(int LocacaoId)
        {
            return GetVeiculos(LocacaoId).Count();
        }
        public static double GetTotal(int LocacaoId)
        {
            Context db = new Context();
            return (
                from veiculo in db.LocacoesVeiculosLeve
                where veiculo.LocacaoId == LocacaoId
                select veiculo.VeiculoLeve.Preco
            ).Sum();
        }
    }
}