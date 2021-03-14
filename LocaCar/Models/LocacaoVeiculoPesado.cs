using System;
using System.Collections.Generic;

namespace Model {
    public class LocacaoVeiculoPesado {
        public string Id { set; get; }
        public int IdLocacao { set; get; }
        public Locacao Locacao { set; get; }
        public int IdVeiculoPesado { set; get; }
        public VeiculoPesado VeiculoPesado { set; get; }

        public static readonly List<LocacaoVeiculoPesado> bancoDeDados = new ();

        public LocacaoVeiculoPesado (
            Locacao Locacao,
            VeiculoPesado VeiculoPesado
        ) {
            this.Locacao = Locacao;
            this.IdLocacao = Locacao.Id;
            this.VeiculoPesado = VeiculoPesado;
            this.IdVeiculoPesado = VeiculoPesado.Id;

            VeiculoPesado.Locacoes.Add (this);
        }
    }
}