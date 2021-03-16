using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller {
    public class Locacao {

        public static Model.Locacao CriarLocacao(
            string IdCliente,
            string StringDataDeLocacao,
            List<Model.VeiculoLeve> VeiculosLeve,
            List<Model.VeiculoPesado> VeiculosPesado
        ) {

            Model.Cliente Cliente = Model.Cliente.GetCliente(Convert.ToInt32(IdCliente));

            DateTime DataDeLocacao;

            try {
                DataDeLocacao = Convert.ToDateTime(StringDataDeLocacao);
                
            } catch {
                DataDeLocacao = DateTime.Now;
            }

            int IntDataDeLocacao = Convert.ToInt32(DataDeLocacao);
            if (IntDataDeLocacao > DateTime.Now.Year) {
                throw new Exception ("Agendamento não permitido!");
            }

            return new Model.Locacao( 
                Cliente,
                DataDeLocacao,
                VeiculosLeve,
                VeiculosPesado
            );
        } 

        public static List<Model.Locacao> GetLocacao () {
            return Model.Locacao.GetLocacao ();
        }
    } 
}