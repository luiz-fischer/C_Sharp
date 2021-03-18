using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

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
            this.Id = Context.locacoes.Count;
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

            // Locacoes.Add (this);
            Context.locacoes.Add (this);

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
            if (LocacaoVeiculoLeve.GetCount(this.Id) > 0) {
                foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id)) {
                    Print += "\n" + veiculo.VeiculoLeve;
                }
            } else {
                Print += "\n    ==> Nada Consta";
            }

            Print += "\n==> Veículos Pesados Locados: ";
            if (LocacaoVeiculoPesado.GetCount(this.Id) > 0) {
                foreach (LocacaoVeiculoPesado veiculo in LocacaoVeiculoPesado.GetVeiculos(this.Id)) {
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

        public static IEnumerable<Locacao> GetLocacao () {
            return from locacao in Context.locacoes select locacao;
        }

        public static int GetCount(int IdCliente) {
            return (from locacao in Context.locacoes where locacao.IdCliente == IdCliente select locacao).Count();
        }

           public DateTime GetDataDevolucao() {
            int DiasParaDevolucao = this.Cliente.DiasParaDevolucao;

            return this.DataDeLocacao.AddDays(DiasParaDevolucao);
        }

        public double GetValorLocacao() {
            double total = 0;

            foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id)) {
                total += veiculo.VeiculoLeve.Preco;
                
            }

            foreach (LocacaoVeiculoPesado veiculo in VeiculosPesado) {
              total += veiculo.VeiculoPesado.Preco;
            }
            total += LocacaoVeiculoPesado.GetTotal(this.Id);

            return total;

        }
    }
}