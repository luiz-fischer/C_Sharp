using System;

namespace Model {
    public abstract class Veiculo {
        protected string Marca { set; get; } 
        protected string Modelo { set; get; } 
        protected int Ano { set; get; } 
        protected double Preco { set; get; } 

        protected Veiculo (
            string Marca,
            string Modelo,
            int Ano,
            double Preco
        ) {
            this.Marca = Marca;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Preco = Preco;
        }

        public override string ToString () {
            return "\nMarca: " + this.Marca +
                "\nModelo: " + this.Modelo +
                "\nAno: " + this.Ano +
                "\nPreço de Locação: " + String.Format ("{0:C}", this.Preco);
        }
    }
}
