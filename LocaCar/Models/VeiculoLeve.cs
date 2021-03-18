using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model {
    public class VeiculoLeve : Veiculo {
        public int Id { set; get; }
        public string Cor { set; get; }
        public List<LocacaoVeiculoLeve> Locacoes { set; get; }
        
        public static readonly List<VeiculoLeve> VeiculosLeve = new ();
        public VeiculoLeve (
            string Marca,
            string Modelo,
            int Ano,
            double Preco,   
            string Cor
        ) : base (Marca, Modelo, Ano, Preco) {
            this.Id = Context.veiculosLeve.Count;
            this.Cor = Cor;
            this.Locacoes = new ();

            VeiculosLeve.Add (this);
            Context.veiculosLeve.Add (this);
        }

        public override string ToString () {
            return 
                "\n|    Id: " + this.Id + 
                "\n|    " + base.ToString () + 
                "\n|    Cor: " + this.Cor;
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            VeiculoLeve VeiculosLeve = (VeiculoLeve) obj;
            return this.GetHashCode () == VeiculosLeve.GetHashCode ();
        }

        public override int GetHashCode () {
            return HashCode.Combine (this.Id);
        }

        public static IEnumerable<VeiculoLeve> GetVeiculoLeve () {
            return from veiculoLeve in Context.veiculosLeve select veiculoLeve;
        }

        public static VeiculoLeve GetVeiculoLeve (int Id) {
            return (
                from veiculoLeve in Context.veiculosLeve 
                where veiculoLeve.Id == Id 
                select veiculoLeve
            ).First();
        }
        public static int GetCount() {
            return GetVeiculoLeve().Count();
        }

    }
}
