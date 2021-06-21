using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Controller
{
    public class Veiculo
    {
        public static void CadastrarVeiculo(
            string marca,
            string modelo,
            string ano,
            string cor,
            string restricao,
            double preco
        )
        {
            new Model.Veiculo(
               marca,
               modelo,
               ano,
               cor,
               restricao,
               Convert.ToDouble(preco)
           );

        }

        public static List<Model.Veiculo> GetVeiculos()
        {
            return Model.Veiculo.GetVeiculos();
        }

        public static Model.Veiculo GetVeiculo(int idVeiculo)
        {
            return Model.Veiculo.GetVeiculo(idVeiculo);
        }

        public static void AtualizarVeiculo(
            int idVeiculo,
            string marca,
            string modelo,
            string ano,
            string cor,
            string restricao,
            double preco
        )
        {
            Model.Veiculo.AtualizarVeiculo(
                idVeiculo,
                marca,
                modelo,
                ano,
                cor,
                restricao,
                preco);
        }

        public static void DeletarVeiculo(int idVeiculo)
        {
            if (Controller.Locacao.GetLocacoesByVeiculo(idVeiculo).Count > 0)
            {
                 MessageBox.Show("Há Locações com essa Marca!");
            }
            Model.Veiculo.DeletarVeiculo(idVeiculo);
        }
    }
}