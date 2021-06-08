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
        public List<Model.Veiculo> veiculos = new List<Model.Veiculo>();

        public Locacao()
        {

        }

        public Locacao(
            Model.Cliente cliente,
            DateTime dataDeLocacao
        )
        {
            this.Id = cliente.IdCliente;  
            this.DataDeLocacao = dataDeLocacao;
            veiculos = new List<Model.Veiculo>();
            cliente.AdicionarLocacao(this);

            var db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();

        }

        // public override string ToString()
        // {
        //     string Print = String.Format(
        //         "\nData da Locação: {0:d}" +
        //         "\nData da Devolução: {1:d}" +
        //         "\nValor: {2:C}" +
        //         "\nCliente: {3}",
        //         this.DataDeLocacao,
        //         this.GetDataDevolucao(),
        //         this.Cliente
        //     );
        //     Print += "\n==> Veículos Leves Locados: ";
        //     if (LocacaoVeiculoLeve.GetCount(this.Id) > 0)
        //     {
        //         foreach (LocacaoVeiculoLeve veiculo in LocacaoVeiculoLeve.GetVeiculos(this.Id))
        //         {
        //             VeiculoLeve veiculoLeve = VeiculoLeve.GetVeiculoLeve(veiculo.VeiculoLeveId);
        //             Print += "\n" + veiculoLeve;
        //         }
        //     }
        //     else
        //     {
        //         Print += "\n    ==> Nada Consta";
        //     }

        //     Print += "\n==> Veículos Pesados Locados: ";
        //     if (LocacaoVeiculoPesado.GetCount(this.Id) > 0)
        //     {
        //         foreach (LocacaoVeiculoPesado veiculo in LocacaoVeiculoPesado.GetVeiculos(this.Id))
        //         {
        //             VeiculoPesado veiculoPesado = VeiculoPesado.GetVeiculoPesado(veiculo.VeiculoPesadoId);
        //             Print += "\n" + veiculoPesado;
        //         }
        //     }
        //     else
        //     {
        //         Print += "\n    ==> Nada Consta";
        //     }

        //     return Print;
        // }

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
        public static List<Model.Locacao> GetLocacoes()
        {
            Context db = new Context();
            return db.Locacoes.ToList();
        }

        public static Model.Locacao GetLocacao(int idLocacao)
        {
            var db = new Context();
            return (from locacao in db.Locacoes
                    where locacao.Id == idLocacao
                    select locacao).First();
        }

public string VeiculosLocados()
        {
            var db = new Context();
            IEnumerable<int> veiculos =
            from veiculo in db.LocacaoVeiculo
            where veiculo.IdLocacao == Id
            select veiculo.IdVeiculo;

            string strVeiculos = "";

            if (veiculos.Count() > 0)
            {
                foreach (int IdVeiculo in veiculos)
                {
                    Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(IdVeiculo);
                    strVeiculos += "ID:                  "  +  veiculo.IdVeiculo +
                                   "\nMarca:            "   + veiculo.Marca +
                                   "\nModelo:          "    + veiculo.Modelo +
                                   "\nAno:               "  + veiculo.Ano +
                                   "\nCor:                " + veiculo.Cor +
                                   "\nRestrição:       "    + veiculo.Restricao +
                                   "\nValor Locação:"       + veiculo.Preco 
                                   ;
                }
            }
            else
            {
                strVeiculos += "    NÃO HÁ VEICULOS!";
            }
            return strVeiculos;
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

        public double ValorTotalLocacao()
        {
            Cliente cliente = Cliente.GetCliente(this.ClienteId);
            int DiasParaDevolucao = cliente.DiasParaDevolucao;
            double total = 0;
            var db = new Context();
            IEnumerable<int> veiculos =
            from veiculo in db.LocacaoVeiculo
            where veiculo.Id == Id
            select veiculo.Id;

            foreach (int id in veiculos)
            {
                Model.Veiculo veiculo = Model.Veiculo.GetVeiculo(id);
                total += veiculo.Preco * DiasParaDevolucao;
            }

            return total;

        }
        // public double ValorLocacao()
        // {
        //     double total = 0;
        //     var db = new Context();
        //     IEnumerable<int> veiculos =
        //     from veiculo in db.LocacaoVeiculo
        //     where veiculo.Id == Id
        //     select veiculo.Id;

        //     foreach (int id in veiculos)
        //     {
        //         Model.Veiculo veiculo = Model.Veiculo.GetVeiculo(id);
        //         total += veiculo.Preco;
        //     }

        //     return total;

        // }

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
        )
        {
            switch (Campo)
            {
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

        public static Locacao GetLast()
        {
            return GetLocacoes().Last();
        }

        public void AdicionarVeiculo(Model.Veiculo veiculo)
        {
            var db = new Context();
            Model.LocacaoVeiculo locacaoVeiculo = new Model.LocacaoVeiculo()
            {
                Id = veiculo.IdVeiculo,
                IdLocacao = Id
            };

            db.LocacaoVeiculo.Add(locacaoVeiculo);
            db.SaveChanges();
        }
        public static List<Model.Locacao> GetLocacoesByCliente(int IdCliente)
        {
            var db = new Context();
            return (from locacao in db.Locacoes
                    where locacao.Id == IdCliente
                    select locacao).ToList();
        }

        public static Locacao DeletarLocacao(int Id)
        {
            Locacao locacao = GetLocacao(Id);
            Context db = new Context();
            db.Locacoes.Remove(locacao);
            db.SaveChanges();
            return locacao;

        }
    }
}