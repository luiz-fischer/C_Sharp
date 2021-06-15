using System;
using System.Collections.Generic;

namespace Controller
{
    public class Locacao
    {        
        public static Model.Locacao Add(Model.Cliente cliente)
        {
            return new Model.Locacao(cliente, DateTime.Now);
        }
        
        public static DateTime CalculoDataDevolucao(DateTime DataLocacao, Model.Cliente Cliente)
        {
            return DataLocacao.AddDays(Cliente.DiasParaDevolucao);
        }
        public static List<Model.Locacao> GetLocacoes()
        {
            return Model.Locacao.GetLocacoes();
        }

        public static Model.Locacao GetLocacao(int idLocacao)
        {
            return Model.Locacao.GetLocacao(idLocacao);
        }
        
        public static List<Model.Locacao> GetLocacoesByCliente(int IdCliente)
        {
            return Model.Locacao.GetLocacoesByCliente(IdCliente);
        }

        public static List<Model.LocacaoVeiculo> GetLocacoesByVeiculo(int IdVeiculo)
        {
            return Model.LocacaoVeiculo.GetLocacoesByVeiculo(IdVeiculo);
        }
        
        public static void DeletarLocacao(int idLocacao)
        {
            Controller.Locacao.DeletarLocacao(idLocacao);
        }
    }
}