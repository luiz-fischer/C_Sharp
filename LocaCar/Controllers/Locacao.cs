using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Controller
{
    public class Locacao
    {
        public static Model.Locacao CriarLocacao(
            string ClienteId,
            string StringDataDeLocacao,
            List<Model.VeiculoLeve> VeiculosLeve,
            List<Model.VeiculoPesado> VeiculosPesado
        )
        {

            Model.Cliente Cliente = Model.Cliente.GetCliente(Convert.ToInt32(ClienteId));

            DateTime DataDeLocacao;

            try
            {
                DataDeLocacao = Convert.ToDateTime(StringDataDeLocacao);

            }
            catch
            {
                DataDeLocacao = DateTime.Now;
            }

            if (DataDeLocacao.Year > DateTime.Now.Year)
            {
                throw new Exception("Ano superior ao atual!");
            }

            if (DataDeLocacao.Year < DateTime.Now.Year)
            {
                throw new Exception("Ano inferior ao atual!");
            }

            if (DataDeLocacao.Month < DateTime.Now.Month)
            {
                throw new Exception("Mês inválido");
            }

            if (DataDeLocacao.Day < DateTime.Now.Day)
            {
                throw new Exception("Dia inválido");
            }


            return new Model.Locacao(
                Cliente,
                DataDeLocacao,
                VeiculosLeve,
                VeiculosPesado
            );
        }

<<<<<<< Updated upstream
        public static IEnumerable<Model.Locacao> GetLocacao()
=======
        public static IEnumerable<Model.Locacao> ListarLocacao () {
            return Model.Locacao.GetLocacoes ();
        }

        public static Model.Locacao GetLocacao (string StringId) {
            int Id = Convert.ToInt32(StringId);
            Model.Locacao LastLocacao = Model.Locacao.GetLast();

            if (Id < 0 || LastLocacao.Id < Id) {
                throw new Exception ("Id informado é inválido.");
            }

            return Model.Locacao.GetLocacao (Id);
        }

         public static Model.Locacao AtualizarLocacao( 
            Model.Locacao locacao,
            string StringCampo,
            string Valor
        ) {
            int campo = Convert.ToInt32(StringCampo);

            switch(campo) {
                case 1:
                    return Model.Locacao.AtualizarLocacao(locacao, 1, Valor);
                case 2:
                    return Model.Locacao.AtualizarLocacao(locacao, 2, Valor);
                default: 
                    throw new Exception("Opção Invalida!");
                
            }
        }

        public static void DeletarLocacao(string StringId)
>>>>>>> Stashed changes
        {
            int Id = Convert.ToInt32(StringId);
            try {
                Model.Locacao.DeletarLocacao(Id);
            } catch (Exception e) {
                Console.WriteLine(e.InnerException.Message);
            }
        }
    }
}