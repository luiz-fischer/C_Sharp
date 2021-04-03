using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class Locacao
    {

        public int Id { set; get; }
        public int ClienteId { set; get; }
        public virtual Cliente Cliente { set; get; }
        public DateTime DataDeLocacao { set; get; }
        public List<LocacaoVeiculoLeve> VeiculosLeve { set; get; }
        public List<LocacaoVeiculoPesado> VeiculosPesado { set; get; }
        public static readonly List<Locacao> Locacoes = new();

        public Locacao() {
            
        }

        public Locacao(
            Cliente Cliente,
            DateTime DataDeLocacao,
            List<VeiculoLeve> VeiculosLeve,
            List<VeiculoPesado> VeiculosPesado
        )
        {
            Context db = new Context();
            // this.Id = Context.Locacoes.Count;
            // this.Cliente = Cliente;
            this.ClienteId = Cliente.Id;
            this.DataDeLocacao = DataDeLocacao;

            db.Locacoes.Add (this);
            db.SaveChanges();


            Locacao locacao = GetLocacoes().Last();
            foreach (VeiculoLeve veiculo in VeiculosLeve)
            {
                LocacaoVeiculoLeve locacaoVeiculoLeve = new (locacao, veiculo);
            }

            foreach (VeiculoPesado veiculo in VeiculosPesado)
            {
                LocacaoVeiculoPesado locacaoVeiculoPesado = new (locacao, veiculo);
            }

            // db.Locacoes.Add (this);
            // db.SaveChanges ();

        }

        public override string ToString()
        {
            string Print = String.Format(
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
            if (LocacaoVeiculoLeve.GetCount(this.Id) > 0)
            {
                foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id))
                {
                    VeiculoLeve veiculoLeve = VeiculoLeve.GetVeiculoLeve(veiculo.VeiculoLeveId);
                    Print += "\n" + veiculoLeve;
                }
            }
            else
            {
                Print += "\n    ==> Nada Consta";
            }

            Print += "\n==> Veículos Pesados Locados: ";
            if (LocacaoVeiculoPesado.GetCount(this.Id) > 0)
            {
                foreach (LocacaoVeiculoPesado veiculo in LocacaoVeiculoPesado.GetVeiculos(this.Id))
                {
                    VeiculoPesado veiculoPesado = VeiculoPesado.GetVeiculoPesado(veiculo.VeiculoPesadoId);
                    Print += "\n" + veiculoPesado;
                }
            }
            else
            {
                Print += "\n    ==> Nada Consta";
            }

            return Print;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            Locacao locacao = (Locacao)obj;
            return this.GetHashCode() == locacao.GetHashCode();
        }
        public static IEnumerable<Locacao> GetLocacoes()
        {
            Context db = new Context();
            return from locacao in db.Locacoes select locacao;
        }
         public static Locacao GetLocacao(int Id)
        {
            Context db = new Context();
            IEnumerable<Locacao> query = from locacao in db.Locacoes where locacao.Id == Id select locacao;

            return query.First();
        }

        public static int GetCount(int ClienteId)
        {
            Context db = new Context();
            return (from locacao in db.Locacoes where locacao.ClienteId == ClienteId select locacao).Count();
        }

        public DateTime GetDataDevolucao()
        {
            Cliente cliente = Cliente.GetCliente(this.ClienteId);
            int DiasParaDevolucao = cliente.DiasParaDevolucao;

            return this.DataDeLocacao.AddDays(DiasParaDevolucao);
        }

        public double GetValorLocacao()
        {
            double total = 0;

            foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id))
            {
                VeiculoLeve veiculoLeve = VeiculoLeve.GetVeiculoLeve(veiculo.VeiculoLeveId);
                total += veiculoLeve.Preco;

            }
            total += LocacaoVeiculoPesado.GetTotal(this.Id);

            return total;

        }
        
        public override int GetHashCode()
        {
            unchecked 
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.Id.GetHashCode();
                return hash;
            }
        }
        public static Locacao AtualizarLocacao(
            Locacao locacao,
            int Campo,
            string Valor
        ) {
            switch(Campo) {
                case 1:
                    locacao.ClienteId = Convert.ToInt32(Valor);
                    break;
                case 2:
                    locacao.DataDeLocacao = Convert.ToDateTime(Valor);
                    break;
            
            }
            Context db = new Context();
            db.Locacoes.Update(locacao);
            db.SaveChanges();

            return locacao;
        }

        public static Locacao GetLast () {
            return GetLocacoes().Last();
        }

        public static Locacao DeletarLocacao(int Id) {
            Locacao locacao = GetLocacao(Id);
            Context db = new Context();
            db.Locacoes.Remove(locacao);
            db.SaveChanges();
            return locacao;

        }
    }
}