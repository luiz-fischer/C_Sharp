using System;

namespace Model {
    public abstract class Veiculo {
        public string Marca { set; get; } 
        public string Modelo { set; get; } 
        public int Ano { set; get; } 
        public double Preco { set; get; } 

        protected Veiculo() {
            
        }
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
            return "\n|    Marca: " + this.Marca +
                "\n|    Modelo: " + this.Modelo +
                "\n|    Ano: " + this.Ano +
                "\n|    Preço de Locação: " + 
                String.Format ("\n|    {0:C}", this.Preco);
        }
    }
}
