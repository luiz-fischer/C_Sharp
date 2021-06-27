using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace LocaCar.Tests
{
    [TestClass]     
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
        [DataRow("Raul Seixas", "10/10/1900", "222.333.444-55", 10)]            // Pass
        [ExpectedException(typeof(ArgumentException), "Cadastro Realizado!")]
        public void Test_ConstrutorCliente_RetornoTrue(
            string Nome,
            string DtNasc,
            string Cpf,
            int DiasDev
        )
        {
            cliente = new(
               Nome,
               DtNasc,
               Cpf,
               DiasDev
            );
            Assert.AreEqual("Cadastro Realizado!", cliente);

        }   

        [DataTestMethod]        // Working
        [DataRow(1, 1)]         // Pass
        [DataRow(2, 2)]         // Pass
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

        [DataTestMethod]                                // Working
        [DataRow(1, "Luiz Carlos Fischer")]            // Pass
        [DataRow(16, "Pedro Carlos Josué")]             // Pass
        public void Test_AtualizarNome_Cliente_RetornoTrue(int IdCliente, string nome)
        {
            try
            {
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome = nome,
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


        [DataTestMethod]                       // Working
        [DataRow(1, "10/10/1992")]            // Pass
        [DataRow(16, "02/02/1999")]            // Pass
        public void Test_AtualizarDtNasc_Cliente_RetornoTrue(int IdCliente, string dataDeNascimento)
        {
            try
            {
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome,
                    atual.DataDeNascimento = dataDeNascimento,
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
        [DataTestMethod]                           // Working
        [DataRow(1, "123.456.789-10")]            // Pass
        [DataRow(16, "987.654.321-00")]            // Pass
        public void Test_AtualizarCpf_Cliente_RetornoTrue(int IdCliente, string cpf)
        {
            try
            {
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome,
                    atual.DataDeNascimento,
                    atual.Cpf = cpf,
                    atual.DiasParaDevolucao
                );
                Assert.AreEqual("Atualizado Com Sucesso!", esperado);

            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        [DataTestMethod]            // Working
        [DataRow(1, 12)]            // Pass
        [DataRow(16, 13)]           // Pass
        public void Test_AtualizarDiasDev_Cliente_RetornoTrue(int IdCliente, int diasParaDevolucao)
        {
            try
            {
                var atual = Model.Cliente.GetCliente(IdCliente);

                var esperado = Model.Cliente.AtualizaCliente(
                    atual.IdCliente,
                    atual.Nome,
                    atual.DataDeNascimento,
                    atual.Cpf,
                    atual.DiasParaDevolucao = diasParaDevolucao
                );
                Assert.AreEqual("Atualizado Com Sucesso!", esperado);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }
        [DataTestMethod]         // Working
        [DataRow(58)]            // Pass
        [DataRow(59)]            // Pass
        public void Test_Deletar_Cliente_RetornoTrue(int IdCliente)
        {
            try
            {
                var esperado = Model.Cliente.DeletarCliente(IdCliente);

                Assert.AreEqual("Deletado Com Sucesso!", esperado);
            }
            catch (ArgumentException)
            {
                Assert.Fail();
            }
        }

        [DataTestMethod]                                                                    // Working
        [DataRow(1, "Luiz Carlos Fischer", "10/10/1992", "123.456.789-10", 12)]            // Pass
        [DataRow(17, "Luiz Otavio Fischer", "10/10/1999", "112.222.333-44", 5)]            // Pass
        public void Test_GetClientes_ReturnTrue(
            int idCliente,
            string Nome,
            string DtNasc,
            string Cpf,
            int DiasDev)
        {

            List<string> listaAtual = new();
            listaAtual.Add(Nome);
            listaAtual.Add(DtNasc);
            listaAtual.Add(Cpf);
            listaAtual.Add(DiasDev.ToString());

            List<Model.Cliente> listaClientes = Model.Cliente.GetClientes();
            List<string> listaEsperado = new();
            foreach (var cliente in listaClientes)
            {
                if (cliente.IdCliente == idCliente)
                {
                    listaEsperado.Add(cliente.Nome);
                    listaEsperado.Add(cliente.DataDeNascimento);
                    listaEsperado.Add(cliente.Cpf);
                    listaEsperado.Add(cliente.DiasParaDevolucao.ToString());
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
            CollectionAssert.AreEqual(listaAtual, listaEsperado);

        }
        [DataTestMethod]    // Working
        [DataRow("")]       // Pass
        [DataRow(null)]     // Pass
        [DataRow(" ")]      // Pass
        public void Test_ValidarCpf_RetornoTrue(string Cpf)
        {
            var resultado = Model.Cliente.ValidarCPF(Cpf);
            Assert.AreEqual("Cpf Inválido!", resultado);
        
        }

        [DataTestMethod]                    // Working
        [DataRow("111.222.333-44")]         // Pass
        [DataRow("123.456.789-10")]         // Pass
        public void Test_ValidarFormatoCpf_RetornoTrue(string Cpf)
        {
            var resultado = Model.Cliente.ValidarFormatoCPF(Cpf);
            Assert.AreEqual("Formato Inválido!", resultado);
            Console.WriteLine(resultado);
        
        }
    }
}
