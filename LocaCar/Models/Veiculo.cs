using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Repository;
using System.Linq;
using System;
using System.Windows.Forms;

namespace Model
{
    public class Veiculo
    {
        [Key]
        public int IdVeiculo { set; get; }
        public string Marca { set; get; } 
        public string Modelo { set; get; } 
        public string Ano { set; get; } 
        public string Cor { set; get; } 
        public string Restricao { set; get; } 
        public double Preco { set; get; } 
        public List<Model.Locacao> locacoes = new();

        public Veiculo(
            string marca,
            string modelo,
            string ano,
            string cor,
            string restricao,
            double preco
        )
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Cor = cor;
            this.Restricao = restricao;
            this.Preco = preco;

            Context db = new();
            db.Veiculos.Add(this);
            db.SaveChanges();
        }

        public Veiculo()
        {

        }

        public static Model.Veiculo GetVeiculo(int idVeiculo)
        {
            Context db = new();
            return (from veiculo in db.Veiculos
                    where veiculo.IdVeiculo == idVeiculo
                    select veiculo).First();
        }
      
        public void AdicionarLocacao(Model.Locacao locacao)
        {
            locacoes.Add(locacao); 
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
            Context db = new();
            try
            {
                Model.Veiculo veiculo = db.Veiculos.First(veiculo => veiculo.IdVeiculo == idVeiculo);
                veiculo.Marca = marca;
                veiculo.Modelo = modelo;
                veiculo.Ano = ano;
                veiculo.Cor = cor;
                veiculo.Restricao = restricao;
                veiculo.Preco = preco;
                db.SaveChanges(); 
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }                
        }

        public static List<Model.Veiculo> GetVeiculos()
        {
            Context db = new();
            return db.Veiculos.ToList();
        }

        public static void DeletarVeiculo(int idVeiculo){
            Context db = new();
            try
            { 
                Model.Veiculo veiculo = db.Veiculos.First(veiculo => veiculo.IdVeiculo == idVeiculo );
                db.Remove(veiculo);
                db.SaveChanges();
            }
            catch (Exception exception)
            {
                MessageBox.Show("ERRO \n" + exception.ToString());
            }        
        }
    }
}