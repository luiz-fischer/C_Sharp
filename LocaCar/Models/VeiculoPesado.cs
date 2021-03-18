using System;
using System.Collections.Generic;
using System.Linq;
using Repository;
namespace Model {
    public class VeiculoPesado : Veiculo {
        public int Id { set; get; }
        public string Restricoes { set; get; }

        public List<LocacaoVeiculoPesado> Locacoes { set; get; }

        public static readonly List<VeiculoPesado> VeiculosPesado = new ();
        public VeiculoPesado (
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base (Marca, Modelo, Ano, Preco) {
            this.Id = Context.veiculosPesado.Count;
            this.Restricoes = Restricoes;
            this.Locacoes = new ();

            VeiculosPesado.Add (this);
            Context.veiculosPesado.Add (this);
        }

        public override string ToString () {
            return 
                "\n|    Id: " + this.Id + 
                "\n|    " + base.ToString () + 
                "\n|    Cor: " + this.Restricoes;
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            VeiculoPesado VeiculoPesado = (VeiculoPesado) obj;
            return this.GetHashCode () == VeiculoPesado.GetHashCode ();
        }

        public override int GetHashCode () {
            return HashCode.Combine (this.Id);
        }

        public static IEnumerable<VeiculoPesado> GetVeiculoPesado () {
            return from veiculoPesado in Context.veiculosPesado select veiculoPesado;
        }
        public static VeiculoPesado GetVeiculoPesado (int Id) {
            return (
                from veiculoPesado in Context.veiculosPesado 
                where veiculoPesado.Id == Id 
                select veiculoPesado
            ).First();
        }
        public static int GetCount() {
            return GetVeiculoPesado().Count();
        }
    }
}
