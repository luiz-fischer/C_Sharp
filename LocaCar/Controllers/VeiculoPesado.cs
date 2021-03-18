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
            return Model.VeiculoPesado.GetVeiculoPesado();
        }

     public static Model.VeiculoPesado GetVeiculoPesado (int Id) {
            int TamanhoLista = Model.VeiculoPesado.GetCount();

            if (Id < 0 || TamanhoLista <= Id) {
                throw new Exception("Id Inválido");
            }
            return Model.VeiculoPesado.GetVeiculoPesado (Id);
        }
    }
}