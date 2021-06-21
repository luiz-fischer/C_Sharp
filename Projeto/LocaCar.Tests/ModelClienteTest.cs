using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Web;
using Repository;

namespace LocaCar.Tests
{
    [TestClass]     // Pass 14
                    // Fail 8
    public class ModelClienteTest
    {

        private Model.Cliente cliente;

        [TestInitialize]
        public void Criar_Objeto_Cliente()
        {
            cliente = new Model.Cliente();

        }

        [DataTestMethod]                                                        // Working
        [DataRow("Luiz Otavio Fischer", "10/10/1999", "112.222.333-44", 5)]     // Pass
        [DataRow("Raul Seixas", "10/10/1900", "111.111.111-11")]                // Fail
        [ExpectedException(typeof(ArgumentException), "Cadastrado Com Sucesso!")]
        public void Test_ConstrutorCliente_RetornoTrue(string Nome, string DtNasc, string Cpf, int DiasDev)
        {
            cliente = new(Nome,
                DtNasc,
                Cpf,
                DiasDev);

            Assert.AreEqual("Cadastrado Com Sucesso!", cliente);
        }

        [DataTestMethod]        // Working
        [DataRow(1, 1)]         // Pass
        [DataRow(2, 2)]         // Pass
        [DataRow(3, 3)]         // Fail
        [DataRow(12, 12)]       // Pass
        [DataRow(13, 13)]       // Pass
        [DataRow(26, 26)]       // Fail
        public void Test_GetCliente_IdCliente_RetornoTrue(int atual, int esperado)
        {
            try
            {
                var resultado = Model.Cliente.GetCliente(esperado).IdCliente;
                Console.WriteLine("ID de Teste: " + atual);
                Console.WriteLine("    ID de Retorno: " + resultado);
                Assert.AreEqual(atual, resultado);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }

        [DataTestMethod]        // Working
        [DataRow(1, null)]      // Pass
        [DataRow(2, null)]      // Pass
        [DataRow(12, null)]     // Fail
        [DataRow(13, null)]     // Fail
        [DataRow(32, null)]     // Fail
        public void Test_NomeCliente_NullEmpty_RetornoFalse(int IdCliente, string Nome)
        {

            try
            {
                var resultado = Model.Cliente.GetCliente(IdCliente);
                
                if (( string.IsNullOrEmpty(resultado.Nome))){
                    throw new ArgumentNullException(resultado.Nome);
                }
                else {
                    Console.WriteLine("Nome: " + resultado.Nome);
                    Assert.AreNotEqual(resultado, Nome);
                }
                    
            }
            catch (ArgumentNullException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]    // Working 
                        // Pass
        public void Test_AtualizarNome_Cliente_RetornoTrue()
        {
            try
            {
                int IdCliente = 1;
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome = "Luiz Carlos Fischer",
                    atual.DataDeNascimento,
                    atual.Cpf,
                    atual.DiasParaDevolucao
                );
                Assert.AreEqual("Atualizado Com Sucesso!", esperado);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        [TestMethod]    // Working 
                        // Pass
        public void Test_AtualizarDtNasc_Cliente_RetornoTrue()
        {
            try
            {
                int IdCliente = 1;
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome,
                    atual.DataDeNascimento = "05/05/1995",
                    atual.Cpf,
                    atual.DiasParaDevolucao
                );
                Assert.AreEqual("Atualizado Com Sucesso!", esperado);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        [TestMethod]    // Working 
                        // Pass
        public void Test_AtualizarCpf_Cliente_RetornoTrue()
        {
            try
            {
                int IdCliente = 1;
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome,
                    atual.DataDeNascimento,
                    atual.Cpf = "333.333.444-55",
                    atual.DiasParaDevolucao
                );
                Assert.AreEqual("Atualizado Com Sucesso!", esperado);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        [TestMethod]    // Working 
                        // Pass
        public void Test_AtualizarDiasDev_Cliente_RetornoTrue()
        {
            try
            {
                int IdCliente = 1;
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome,
                    atual.DataDeNascimento,
                    atual.Cpf,
                    atual.DiasParaDevolucao = 10
                );
                Assert.AreEqual("Atualizado Com Sucesso!", esperado);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        [TestMethod]    // Working 
                        // Pass
        public void Test_Deletar_Cliente_RetornoTrue()
        {
            try
            {
                int IdCliente = 32;
                var esperado = Model.Cliente.DeletarCliente(IdCliente);

                Assert.AreEqual("Deletado Com Sucesso!", esperado);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }

        [TestMethod]    // Working
                        // Pass
        public void Test_GetClientes_ReturnTrue()
        {
            string idCliente = "1";
            string Nome = "Luiz Carlos Fischer";
            string DtNasc = "05/05/1995";
            string Cpf = "333.333.444-55";
            string DiasDev = "10";

            List<string> listaAtual = new();
            listaAtual.Add(idCliente);
            listaAtual.Add(Nome);
            listaAtual.Add(DtNasc);
            listaAtual.Add(Cpf);
            listaAtual.Add(DiasDev);
            try
            {
                List<Model.Cliente> listaClientes = Model.Cliente.GetClientes();
                List<string> listaEsperado = new();
                foreach (var cliente in listaClientes)
                {
                    if ((cliente.IdCliente.ToString() == idCliente)
                    && (cliente.Nome == Nome)
                    && (cliente.DataDeNascimento == DtNasc)
                    && (cliente.Cpf == Cpf)
                    && (cliente.DiasParaDevolucao.ToString() == DiasDev)
                    )

                    {
                        listaEsperado.Add(cliente.IdCliente.ToString());
                        listaEsperado.Add(cliente.Nome);
                        listaEsperado.Add(cliente.DataDeNascimento);
                        listaEsperado.Add(cliente.Cpf);
                        listaEsperado.Add(cliente.DiasParaDevolucao.ToString());
                        CollectionAssert.AreEqual(listaAtual, listaEsperado);
                    }
                    else
                    {
                        continue;
                    }
                }
                foreach (var esperado in listaEsperado)
                {
                    Console.WriteLine(esperado);
                }
                foreach (var atual in listaAtual)
                {
                    Console.WriteLine(atual);
                }
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }


        }
    }
}
