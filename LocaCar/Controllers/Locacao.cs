using System;
using System.Collections.Generic;

namespace Controller {
    public class Locacao {

        public static Model.Locacao CriarLocacao(
            string Id,
            string IdVeiculoLeve,
            string DataDeLocacao
        ) {

            Model.Cliente Cliente = Model.Cliente.GetCliente(Convert.ToInt32(Id));

            Model.VeiculoLeve VeiculoLeve = Model.VeiculoLeve.GetVeiculoLeve(Convert.ToInt32(IdVeiculoLeve));

            return new Model.Locacao( 
                Cliente,
                VeiculoLeve,
                DataDeLocacao
            );
        } 

        public static List<Model.Locacao> GetLocacao () {
            return Model.Locacao.GetLocacao ();
        }
    } 
}