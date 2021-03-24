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

        public VeiculoPesado(): base() {

        }
        public VeiculoPesado (
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base (Marca, Modelo, Ano, Preco) {
            Context db = new Context();
            // this.Id = Context.VeiculosPesado.Count;
            this.Restricoes = Restricoes;
            this.Locacoes = new ();

            // VeiculosPesado.Add (this);
            db.VeiculosPesado.Add (this);
            db.SaveChanges();

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
            Context db = new Context();
            return from veiculoPesado in db.VeiculosPesado select veiculoPesado;
        }
        public static VeiculoPesado GetVeiculoPesado (int Id) {
            Context db = new Context();
            return (
                from veiculoPesado in db.VeiculosPesado 
                where veiculoPesado.Id == Id 
                select veiculoPesado
            ).First();
        }
        public static int GetCount() {
            return GetVeiculoPesado().Count();
        }
    }
}
