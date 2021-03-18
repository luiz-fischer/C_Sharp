using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model {
    public class LocacaoVeiculoLeve {
        public string Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao Locacao { set; get; }
        public int IdVeiculoLeve { set; get; }
        public VeiculoLeve VeiculoLeve { set; get; }

        public static readonly List<LocacaoVeiculoLeve> bancoDeDados = new ();

        public LocacaoVeiculoLeve (
            Locacao Locacao,
            VeiculoLeve VeiculoLeve
        ) {
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoLeve = VeiculoLeve;
            this.IdVeiculoLeve = VeiculoLeve.Id;

            // VeiculoLeve.Locacoes.Add (this);
            Context.locacoesVeiculosLeve.Add (this);
        }

        public static IEnumerable<LocacaoVeiculoLeve> GetVeiculos(int IdLocacao) {
            return from veiculo in Context.locacoesVeiculosLeve where veiculo.IdLocacao == IdLocacao select veiculo;
        }

        public static int GetCount(int IdLocacao) {
            return GetVeiculos(IdLocacao).Count();
        }
        public static double GetTotal(int IdLocacao) {
            return (
                from veiculo in Context.locacoesVeiculosLeve 
                where veiculo.IdLocacao == IdLocacao 
                select veiculo.VeiculoLeve.Preco
            ).Sum();
        }
    }
}