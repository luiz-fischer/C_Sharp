using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoLeve
    {
        public static Model.VeiculoLeve CriarVeiculoLeve(
            string Marca,
            string Modelo,
            string Ano,
            string Preco,
            string Restricoes
        )
        {
            int ConverterAno = Convert.ToInt32(Ano);
            double ConverterPreco = Convert.ToDouble(Preco);
            int AnoAtual = Convert.ToInt32(DateTime.Now);


            if (ConverterAno < 1990)
            {
                throw new Exception("Carro muito antigo");
            }

            if (ConverterPreco < 0)
            {
                throw new Exception("Valor não pode ser negativo");
            }

            if (ConverterAno > AnoAtual) 
            {
                throw new Exception("Ano inválido");
            }

            return new Model.VeiculoLeve(
                Marca,
                Modelo,
                ConverterAno,
                ConverterPreco,
                Restricoes
            );
        }

        public static List<Model.VeiculoLeve> ListarVeiculoLeve ()
        {
            return Model.VeiculoLeve.GetVeiculoLeve ();
        }

        public static Model.VeiculoLeve GetVeiculoLeve (int Id) {
            int TamanhoLista = Model.VeiculoLeve.GetVeiculoLeve ().Count;

            if (Id < 0 || TamanhoLista <= Id) {
                throw new Exception("Id Inválido");
            }
            return Model.VeiculoLeve.GetVeiculoLeve (Id);
        }
    }
}
