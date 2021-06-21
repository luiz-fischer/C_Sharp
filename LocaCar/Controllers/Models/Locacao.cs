using System;
using System.Linq;
using Repository;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class Locacao
    {
        
        [Key] 
        public int IdLocacao { get; set; }
        public virtual Model.Cliente Cliente { get; set; }
        [ForeignKey("clientes")] 
        public int IdCliente { get; set; }
        [Required] 
        public DateTime DataLocacao { get; set; }
        public List<Model.Veiculo> veiculos = new();

        public Locacao()
        {

        }

        public Locacao(
            Model.Cliente cliente,
            DateTime dataLocacao
        )
        {
            IdCliente = cliente.IdCliente;
            DataLocacao = dataLocacao;
            veiculos = new List<Model.Veiculo>();
            cliente.AdicionarLocacao(this);

            var db = new Context();
            db.Locacoes.Add(this);
            db.SaveChanges();

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
        public static List<Model.Locacao> GetLocacoes()
        {
            Context db = new();
            return db.Locacoes.ToList();                                                                                                                                                                                                
        }

        public static Model.Locacao GetLocacao(int idLocacao)
        {
            Context db = new();
            return (from locacao in db.Locacoes
                    where locacao.IdLocacao == idLocacao
                    select locacao).First();
        }


        public string VeiculosLocados()
        {
            Context db = new();
            IEnumerable<int> veiculos =
            from veiculo in db.LocacaoVeiculo
            where veiculo.IdLocacao == IdLocacao
            select veiculo.IdVeiculo;

            string strVeiculos = "";

            if (veiculos.Any())
            {
                foreach (int IdVeiculo in veiculos)
                {
                    Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(IdVeiculo);
                    strVeiculos += "ID:                                "    + veiculo.IdVeiculo +
                                   "\nMarca:                          "     + veiculo.Marca +
                                   "\nModelo:                        "      + veiculo.Modelo +
                                   "\nAno:                             "    + veiculo.Ano +
                                   "\nCor:                              "   + veiculo.Cor +
                                   "\nRestrição:                    "       + veiculo.Restricao +
                                   "\nValor Locação:            "           + veiculo.Preco.ToString("C2")
                                   ;
                }
            }
            else
            {
                strVeiculos += "    NÃO HÁ VEICULOS!";
            }
            return strVeiculos;
        }
        public string GetValorDiariaByLocacao()
        {
            var db = new Context();
            IEnumerable<int> veiculos =
            from veiculo in db.LocacaoVeiculo
            where veiculo.IdLocacao == IdLocacao
            select veiculo.IdVeiculo;

            string strVeiculos = "";

            if (veiculos.Any())
            {
                foreach (int IdVeiculo in veiculos)
                {
                    Model.Veiculo veiculo = Controller.Veiculo.GetVeiculo(IdVeiculo);
                    strVeiculos += veiculo.Preco.ToString("C2");
                }
            }
            else
            {
                strVeiculos += "    NÃO HÁ VEICULOS!";
            }
            return strVeiculos;
        }
        public static int GetCount(int IdCliente)
        {
            Context db = new();
            return (from locacao in db.Locacoes 
                where locacao.IdCliente == IdCliente 
                select locacao).Count();
        }

        public DateTime GetDataDevolucao()
        { 
            Cliente cliente = Cliente.GetCliente(IdCliente);
            int DiasParaDevolucao = cliente.DiasParaDevolucao;

            return this.DataLocacao.AddDays(DiasParaDevolucao);
        }
   
        public double ValorTotalLocacao()
        {
            Cliente cliente = Cliente.GetCliente(this.IdCliente);
            int DiasParaDevolucao = cliente.DiasParaDevolucao;

            double total = 0;
            Context db = new();
            IEnumerable<int> veiculos =
            from veiculo in db.LocacaoVeiculo
            where veiculo.IdLocacao == IdLocacao
            select veiculo.IdVeiculo;

            foreach (int id in veiculos)
            {
                Model.Veiculo veiculo = Model.Veiculo.GetVeiculo(id);
                total += veiculo.Preco * DiasParaDevolucao;
            }

            return total;

        }
        public int QtdeVeiculosLocados()
        {
            Context db = new();
            IEnumerable<int> veiculos =
            from veiculo in db.LocacaoVeiculo
            where veiculo.IdLocacao == IdLocacao
            select veiculo.IdVeiculo;

            Model.Cliente cliente = Model.Cliente.GetCliente(IdCliente);

            return veiculos.Count();
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = (int)2166136261;
                hash = (hash * 16777619) ^ this.IdLocacao.GetHashCode();
                return hash;
            }
        }

        public void AdicionarVeiculo(Model.Veiculo veiculo)
        {
            Context db = new();
            Model.LocacaoVeiculo locacaoVeiculo = new()
            {
                IdVeiculo = veiculo.IdVeiculo,
                IdLocacao = IdLocacao
            };

            db.LocacaoVeiculo.Add(locacaoVeiculo);
            db.SaveChanges();
        }
        public static List<Model.Locacao> GetLocacoesByCliente(int IdCliente)
        {
            Context db = new();
            return (from locacao in db.Locacoes
                    where locacao.IdCliente == IdCliente
                    select locacao).ToList();
        }

        public static Locacao DeletarLocacao(int Id)
        {
            Locacao locacao = GetLocacao(Id);
            Context db = new();
            db.Locacoes.Remove(locacao);
            db.SaveChanges();
            return locacao;

        }
    }
}