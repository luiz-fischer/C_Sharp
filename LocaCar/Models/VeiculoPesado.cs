using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
namespace Model
{
    public class VeiculoPesado : Veiculo
    {
        public int Id { set; get; }
        public string Restricoes { set; get; }

        public List<LocacaoVeiculoPesado> Locacoes { set; get; }

        public static readonly List<VeiculoPesado> VeiculosPesado = new();

        public VeiculoPesado() : base()
        {

        }
        public VeiculoPesado(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base(Marca, Modelo, Ano, Preco)
        {
            Context db = new Context();
            // this.Id = Context.VeiculosPesado.Count;
            this.Restricoes = Restricoes;
            this.Locacoes = new();

<<<<<<< Updated upstream
            // VeiculosPesado.Add (this);
            db.VeiculosPesado.Add (this);
=======
            db.VeiculosPesado.Add(this);
>>>>>>> Stashed changes
            db.SaveChanges();

        }

        public override string ToString()
        {
            return
                "\n|    Id: " + this.Id +
                "\n|    " + base.ToString() +
                "\n|    Cor: " + this.Restricoes;
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
            VeiculoPesado VeiculoPesado = (VeiculoPesado)obj;
            return this.GetHashCode() == VeiculoPesado.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

        public static IEnumerable<VeiculoPesado> GetVeiculosPesado()
        {
            Context db = new Context();
            return from veiculoPesado in db.VeiculosPesado select veiculoPesado;
        }

        public static VeiculoPesado GetVeiculoPesado(int Id)
        {
            Context db = new Context();
            return (
                from veiculoPesado in db.VeiculosPesado
                where veiculoPesado.Id == Id
                select veiculoPesado
            ).First();
        }
        public static int GetCount()
        {
            return GetVeiculosPesado().Count();
        }
        public static VeiculoPesado AtualizarVeiculoPesado(
           VeiculoPesado veiculoPesado,
           int Campo,
           string Valor
       )
        {
            switch (Campo)
            {
                case 1:
                    veiculoPesado.Marca = Valor;
                    break;
                case 2:
                    veiculoPesado.Modelo = Valor;
                    break;
                case 3:
                    veiculoPesado.Ano = Convert.ToInt32(Valor);
                    break;
                case 4:
                    veiculoPesado.Restricoes = Valor;
                    break;
                case 5:
                    veiculoPesado.Preco = Convert.ToInt32(Valor);
                    break;

            }
            Context db = new Context();
            db.VeiculosPesado.Update(veiculoPesado);
            db.SaveChanges();

            return veiculoPesado;
        }

        public static VeiculoPesado GetLast()
        {
            return GetVeiculosPesado().Last();
        }

        public static void DeletarVeiculoPesado(
            int Valor
            )
        {
            Context db = new Context();
            db.VeiculosPesado.Remove(GetVeiculoPesado(Valor));
            db.SaveChanges();

        }
    }
}
