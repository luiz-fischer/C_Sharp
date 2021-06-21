using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LocaCar.Tests
{
    [TestClass]
    public class LocacaoTest
    {
        private Model.Locacao locacao;

        [TestInitialize]
        public void Criar_Objeto_Locacao()
        {
            locacao = new Model.Locacao();

        }

        [DataTestMethod]                                  // Working
        [DataRow(1, "16/06/2021", "26/06/2021", 10)]      // Pass
        [DataRow(2, "08/06/2021", "28/06/2021", 20)]      // Pass
        [DataRow(12, "08/06/2021", "26/06/2021", 20)]     // Fail
        [DataRow(13, "08/06/2021", "21/06/2021", 20)]     // Fail

        public void Test_GetDataDevolucao_RetornoTrue(int IdCliente, string atual, string esperado, int QtdDias)
        {

            Model.Cliente cliente = Model.Cliente.GetCliente(IdCliente);
            int DiasDev = cliente.DiasParaDevolucao;
            DateTime atualDate2 = Convert.ToDateTime(atual).AddDays(QtdDias);

            if (QtdDias == DiasDev)
            {
                Model.Locacao locacao = Model.Locacao.GetLocacao(IdCliente);
                DateTime atualDate = locacao.GetDataDevolucao();
                DateTime esperadoDate = Convert.ToDateTime(esperado);
                Assert.AreEqual(atualDate.ToShortDateString(), esperadoDate.ToShortDateString(), atualDate2.ToShortDateString());
            }
            else
            {
                Assert.Fail();
            }

        }


    }
}
