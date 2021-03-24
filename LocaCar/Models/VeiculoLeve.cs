using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model {
    public class VeiculoLeve : Veiculo {
        public int Id { set; get; }
        public string Cor { set; get; }
        
        public static readonly List<VeiculoLeve> VeiculosLeve = new ();
        public VeiculoLeve() : base() {

        }
        public VeiculoLeve (
            string Marca,
            string Modelo,
            int Ano,
            double Preco,   
            string Cor
        ) : base (Marca, Modelo, Ano, Preco) {
            Context db = new Context();
            // this.Id = Context.VeiculosLeve.Count;
            this.Cor = Cor;

            db.VeiculosLeve.Add (this);
            db.SaveChanges();

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
            Context db = new Context();
            return from veiculoLeve in db.VeiculosLeve select veiculoLeve;
        }

        public static VeiculoLeve GetVeiculoLeve (int Id) {
            Context db = new Context();
            return (
                from veiculoLeve in db.VeiculosLeve 
                where veiculoLeve.Id == Id 
                select veiculoLeve
            ).First();
        }
        public static int GetCount() {
            return GetVeiculoLeve().Count();
        }

    }
}
