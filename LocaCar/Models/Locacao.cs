using System;
using System.Collections.Generic;

namespace Model {
    public class Locacao {
        public int Id { set; get; }
        public int IdCliente { set; get; }
        public Cliente Cliente { set; get; }
        public DateTime DataDeLocacao { set; get; }

        public  List<LocacaoVeiculoLeve> VeiculosLeve { set; get; }
        public List<LocacaoVeiculoPesado> VeiculosPesado { set; get; }

        public static readonly List<Locacao> Locacoes = new ();

        public Locacao(
            Cliente Cliente,
            DateTime DataDeLocacao,
            List<VeiculoLeve> VeiculosLeve,
            List<VeiculoPesado> VeiculosPesado
        ) 
        {
            this.Cliente = Cliente;
            this.IdCliente = Cliente.Id;
            this.DataDeLocacao = DataDeLocacao;
            this.VeiculosLeve = new ();
            this.VeiculosPesado = new ();

            Cliente.Locacoes.Add(this);

            foreach (VeiculoLeve veiculo in VeiculosLeve) {
                LocacaoVeiculoLeve locacaoVeiculoLeve = new (this, veiculo);
                this.VeiculosLeve.Add (locacaoVeiculoLeve);
            }

            foreach (VeiculoPesado veiculo in VeiculosPesado) {
              LocacaoVeiculoPesado locacaoVeiculoPesado = new (this, veiculo);
              this.VeiculosPesado.Add (locacaoVeiculoPesado);
          }

            Locacoes.Add (this);

        }

        public double GetValorLocacao() {
            double total = 0;

            foreach (LocacaoVeiculoLeve veiculo in VeiculosLeve) {
                total += veiculo.VeiculoLeve.Preco;
                
            }

            foreach (LocacaoVeiculoPesado veiculo in VeiculosPesado) {
              total += veiculo.VeiculoPesado.Preco;
            }

            return total;

        }

        public DateTime GetDataDevolucao() {
            int DiasParaDevolucao = this.Cliente.DiasParaDevolucao;

            return this.DataDeLocacao.AddDays(DiasParaDevolucao);
        }

        public override string ToString () {
            string Print = String.Format (
                "\nData da Locação: {0:d}" + 
                "\nData da Devolução: {1:d}" + 
                "\nValor: {2:C}" + 
                "\nCliente: {3}",
                this.DataDeLocacao,
                this.GetDataDevolucao(),
                this.GetValorLocacao(),
                this.Cliente
            );
            Print += "\n==> Veículos Leves Locados: ";
            if (VeiculosLeve.Count > 0) {
                foreach (LocacaoVeiculoLeve veiculo in VeiculosLeve) {
                    Print += "\n" + veiculo.VeiculoLeve;
                }
            } else {
                Print += "\n    ==> Nada Consta";
            }

            Print += "\n==> Veículos Pesados Locados: ";
            if (VeiculosPesado.Count > 0) {
                foreach (LocacaoVeiculoPesado veiculo in VeiculosPesado) {
                    Print += "\n" + veiculo.VeiculoPesado;
                }
            } else {
                Print += "\n    ==> Nada Consta";
            }

            return Print;
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            Locacao locacao = (Locacao) obj;
            return this.GetHashCode () == locacao.GetHashCode ();
        }

        public override int GetHashCode () {
            return HashCode.Combine (this.Id);
        }

         public static List<Locacao> GetLocacao () {
            return Locacoes;
        }
    }
}