using System;
using System.Collections.Generic;

namespace Model {

    public class Locacao {

        public int Id { set; get; }

        public string DadaDeLocacao { set; get; }
        public Cliente Cliente { set; get; }

        public VeiculoLeve VeiculoLeve {set; get; }

        public static readonly List<Locacao> locacoes = new ();

        public Locacao(
            Cliente Cliente,
            VeiculoLeve VeiculoLeve,
            string DadaDeLocacao
        ) 
        {
            this.Cliente = Cliente;
            this.VeiculoLeve = VeiculoLeve;
            this.DadaDeLocacao = DadaDeLocacao;

            locacoes.Add (this);

        }

         public override string ToString () {
            return this.Cliente +
                "\nData: " + this.DadaDeLocacao +
                this.VeiculoLeve;
        }

        public override bool Equals (object obj) {
            if (obj == null) {
                return false;
            }
            if (obj.GetType () != this.GetType ()) {
                return false;
            }
            Locacao locacoes = (Locacao) obj;
            return this.GetHashCode () == locacoes.GetHashCode ();
        }

        public override int GetHashCode () {
            return HashCode.Combine (this.Id);
        }

         public static List<Locacao> GetLocacao () {
            return locacoes;
        }
    }
}