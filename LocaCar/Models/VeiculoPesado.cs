using System;
using System.Collections.Generic;

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
            this.Id = VeiculosPesado.Count;
            this.Restricoes = Restricoes;
            this.Locacoes = new ();

            VeiculosPesado.Add (this);
        }

        public override string ToString () {
            return "Id: " + this.Id + " - " + base.ToString () + "\nRestrições: " + this.Restricoes;
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
            return VeiculosPesado;
        }
        public static VeiculoPesado GetVeiculoPesado (int Id) {
            return VeiculosPesado[Id];
        }
    }
}
