using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model {
    public class LocacaoVeiculoPesado {
        public string Id { set; get; }
        public int LocacaoId { set; get; }
        public Locacao Locacao { set; get; }
        public int VeiculoPesadoId { set; get; }
        public VeiculoPesado VeiculoPesado { set; get; }

        public static readonly List<LocacaoVeiculoPesado> bancoDeDados = new ();

        public LocacaoVeiculoPesado() {

        }

        public LocacaoVeiculoPesado (
            Locacao Locacao,
            VeiculoPesado VeiculoPesado
        ) {
            Context db = new Context();
            this.Locacao = Locacao;
            this.LocacaoId = Locacao.Id;
            this.VeiculoPesado = VeiculoPesado;
            this.VeiculoPesadoId = VeiculoPesado.Id;

            db.LocacoesVeiculosPesado.Add (this);
            db.SaveChanges();


        }

        public static IEnumerable<LocacaoVeiculoPesado> GetVeiculos(int LocacaoId) {
            Context db = new Context();
            return from veiculo in db.LocacoesVeiculosPesado where veiculo.LocacaoId == LocacaoId select veiculo;
        }

        public static int GetCount(int LocacaoId) {
            return GetVeiculos(LocacaoId).Count();
        }
        public static double GetTotal(int LocacaoId) {
            Context db = new Context();
            return (
                from veiculo in db.LocacoesVeiculosPesado 
                where veiculo.LocacaoId == LocacaoId 
                select veiculo.VeiculoPesado.Preco
            ).Sum();
        }
    }
}