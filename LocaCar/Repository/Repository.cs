using System.Collections.Generic;
using Model;

namespace Repository
{
    public class Context 
    {
        public static readonly List<Cliente> clientes = new ();
        public static readonly List<VeiculoPesado> veiculosPesado = new ();
        public static readonly List<VeiculoLeve> veiculosLeve = new ();
        public static readonly List<Locacao> locacoes = new ();
        public static readonly List<LocacaoVeiculoPesado> locacoesVeiculosPesado = new ();
        public static readonly List<LocacaoVeiculoLeve> locacoesVeiculosLeve = new ();

    }
}