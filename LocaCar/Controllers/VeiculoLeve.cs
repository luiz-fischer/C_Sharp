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
                throw new Exception("Ano superior ao ano atual!");
            }

            return new Model.VeiculoLeve(
                Marca,
                Modelo,
                ConverterAno,
                ConverterPreco,
                Restricoes
            );
        }

        public static IEnumerable<Model.VeiculoLeve> ListarVeiculoLeve ()
        {
            return Model.VeiculoLeve.GetVeiculoLeve ();
        }

        public static Model.VeiculoLeve GetVeiculoLeve (int Id) {
            int TamanhoLista = Model.VeiculoLeve.GetCount();

            if (Id < 0 || TamanhoLista <= Id) {
                throw new Exception("Id Inválido");
            }
            return Model.VeiculoLeve.GetVeiculoLeve (Id);
        }
<<<<<<< Updated upstream
=======

        public static Model.VeiculoLeve AtualizarVeiculoLeve( 
            Model.VeiculoLeve veiculoLeve,
            string StringCampo,
            string Valor
        ) {
            int campo = Convert.ToInt32(StringCampo);

            switch(campo) {
                case 1:
                    return Model.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve, 1, Valor);
                case 2:
                    return Model.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve, 2, Valor);
                case 3:
                    return Model.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve, 3, Valor);
                case 4:
                    return Model.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve, 4, Valor);
                case 5:
                    return Model.VeiculoLeve.AtualizarVeiculoLeve(veiculoLeve, 5, Valor);
                default: 
                    throw new Exception("Opção Invalida!");
                
            }
        }

        public static void DeletarVeiculoLeve(string StringId)
        {
            int Id = Convert.ToInt32(StringId);
            try {
                Model.VeiculoLeve.DeletarVeiculoLeve(Id);
            } catch (Exception e) {
                Console.WriteLine(e.InnerException.Message);
            }
        }
>>>>>>> Stashed changes
    }
}
