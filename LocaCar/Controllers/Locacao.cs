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

            if (DataDeLocacao.Year > DateTime.Now.Year) {
                throw new Exception ("Ano superior ao atual!");
            } 
            
            if (DataDeLocacao.Year < DateTime.Now.Year) {
                throw new Exception ("Ano inferior ao atual!");
            }

            if (DataDeLocacao.Month < DateTime.Now.Month) {
                throw new Exception ("Mês inválido");
            }

             if (DataDeLocacao.Day < DateTime.Now.Day) {
                throw new Exception ("Dia inválido");
            }
            

            return new Model.Locacao( 
                Cliente,
                DataDeLocacao,
                VeiculosLeve,
                VeiculosPesado
            );
        } 

        public static IEnumerable<Model.Locacao> GetLocacao () {
            return Model.Locacao.GetLocacao ();
        }
    } 
}