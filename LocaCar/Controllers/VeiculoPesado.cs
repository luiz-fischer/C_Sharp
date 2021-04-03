using System;
using System.Collections.Generic;

namespace Controller
{
    public class VeiculoPesado
    {
        public static Model.VeiculoPesado CriarVeiculoPesado(
            string Brand,
            string Model,
            string Year,
            string Price,
            string Restrictions
        )
        {
            int ConvertYear = Convert.ToInt32(Year);
            double ConvertPrice = Convert.ToDouble(Price);

            if (ConvertYear < 1990)
            {
                throw new Exception("Carro muito antigo");
            }

            if (ConvertPrice < 0)
            {
                throw new Exception("Valor não pode ser negativo");
            }

            return new Model.VeiculoPesado(
                Brand,
                Model,
                ConvertYear,
                ConvertPrice,
                Restrictions
            );
        }

        public static IEnumerable<Model.VeiculoPesado> GetVeiculoPesado()
        {
            return Model.VeiculoPesado.GetVeiculosPesado();
        }

        public static Model.VeiculoPesado GetVeiculoPesado(int Id)
        {
            int TamanhoLista = Model.VeiculoPesado.GetCount();

            if (Id < 0 || TamanhoLista <= Id)
            {
                throw new Exception("Id Inválido");
            }
            return Model.VeiculoPesado.GetVeiculoPesado(Id);
        }

        public static Model.VeiculoPesado AtualizarVeiculoPesado(
            Model.VeiculoPesado veiculoPesado,
            string StringCampo,
            string Valor
        )
        {
            int campo = Convert.ToInt32(StringCampo);

            switch (campo)
            {
                case 1:
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, 1, Valor);
                case 2:
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, 2, Valor);
                case 3:
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, 3, Valor);
                case 4:
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, 4, Valor);
                case 5:
                    return Model.VeiculoPesado.AtualizarVeiculoPesado(veiculoPesado, 5, Valor);
                default:
                    throw new Exception("Opção Invalida!");

            }
        }

        public static void DeletarVeiculoPesado(string StringId)
        {
            int Id = Convert.ToInt32(StringId);
            try
            {
                Model.VeiculoPesado.DeletarVeiculoPesado(Id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.InnerException.Message);
            }
        }
    }

}