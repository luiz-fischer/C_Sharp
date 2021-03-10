using System;
using System.Collections.Generic;

namespace Model {
    public class VeiculoPesado : Veiculo {
        public int Id { set; get; }
        public string Restricoes { set; get; }

        public static readonly List<VeiculoPesado> veiculosPesado = new ();
        public VeiculoPesado (
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Restricoes
        ) : base (Marca, Modelo, Ano, Preco) {
            this.Id = veiculosPesado.Count;
            this.Restricoes = Restricoes;

            veiculosPesado.Add (this);
        }

        public override string ToString () {
            return base.ToString () + "\nRestrições: " + this.Restricoes;
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

        public static List<VeiculoPesado> GetVeiculoPesado () {
            return veiculosPesado;
        }
    }
}
