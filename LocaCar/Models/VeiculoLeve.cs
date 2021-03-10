using System;
using System.Collections.Generic;

namespace Model {
    public class VeiculoLeve : Veiculo {
        public int Id { set; get; }
        public string Cor { set; get; }

        public static readonly List<VeiculoLeve> veiculoLeves = new ();
        public VeiculoLeve (
            string Marca,
            string Modelo,
            int Ano,
            double Preco,   
            string Cor
        ) : base (Marca, Modelo, Ano, Preco) {
            this.Id = veiculoLeves.Count;
            this.Cor = Cor;

            veiculoLeves.Add (this);
        }

        public override string ToString () {
            return base.ToString () + "\nCor: " + this.Cor;
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            VeiculoLeve VeiculoLeves = (VeiculoLeve) obj;
            return this.GetHashCode () == VeiculoLeves.GetHashCode ();
        }

        public override int GetHashCode () {
            return HashCode.Combine (this.Id);
        }

        public static List<VeiculoLeve> GetVeiculoLeve () {
            return veiculoLeves;
        }

        public static VeiculoLeve GetVeiculoLeve(int IdVeiculoLeve)
        {
            return veiculoLeves[IdVeiculoLeve];
        }


    }
}
