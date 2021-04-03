using System;
using System.Collections.Generic;
using System.Linq;
using Repository;

namespace Model
{
    public class VeiculoLeve : Veiculo
    {
        public int Id { set; get; }
        public string Cor { set; get; }

        public static readonly List<VeiculoLeve> VeiculosLeve = new();
        public VeiculoLeve() : base()
        {

        }
        public VeiculoLeve(
            string Marca,
            string Modelo,
            int Ano,
            double Preco,
            string Cor
        ) : base(Marca, Modelo, Ano, Preco)
        {
            Context db = new Context();
            // this.Id = Context.VeiculosLeve.Count;
            this.Cor = Cor;

            db.VeiculosLeve.Add(this);
            db.SaveChanges();

        }

        public override string ToString()
        {
            return
                "\n|    Id: " + this.Id +
                "\n|    " + base.ToString() +
                "\n|    Cor: " + this.Cor;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (obj.GetType() != this.GetType())
            {
                return false;
            }
            VeiculoLeve VeiculosLeve = (VeiculoLeve)obj;
            return this.GetHashCode() == VeiculosLeve.GetHashCode();
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.Id);
        }

<<<<<<< Updated upstream
        public static IEnumerable<VeiculoLeve> GetVeiculoLeve () {
=======
        public static IEnumerable<VeiculoLeve> GetVeiculosLeve()
        {
>>>>>>> Stashed changes
            Context db = new Context();
            return from veiculoLeve in db.VeiculosLeve select veiculoLeve;
        }

        public static VeiculoLeve GetVeiculoLeve(int Id)
        {
            Context db = new Context();
            return (
                from veiculoLeve in db.VeiculosLeve
                where veiculoLeve.Id == Id
                select veiculoLeve
            ).First();
        }
<<<<<<< Updated upstream
        public static int GetCount() {
            return GetVeiculoLeve().Count();
=======
        public static int GetCount()
        {
            return GetVeiculosLeve().Count();
        }

        public static VeiculoLeve AtualizarVeiculoLeve(
            VeiculoLeve veiculoLeve,
            int Campo,
            string Valor
        )
        {
            switch (Campo)
            {
                case 1:
                    veiculoLeve.Marca = Valor;
                    break;
                case 2:
                    veiculoLeve.Modelo = Valor;
                    break;
                case 3:
                    veiculoLeve.Ano = Convert.ToInt32(Valor);
                    break;
                case 4:
                    veiculoLeve.Cor = Valor;
                    break;
                case 5:
                    veiculoLeve.Preco = Convert.ToInt32(Valor);
                    break;

            }
            Context db = new Context();
            db.VeiculosLeve.Update(veiculoLeve);
            db.SaveChanges();

            return veiculoLeve;
        }

        public static VeiculoLeve GetLast()
        {
            return GetVeiculosLeve().Last();
        }

        public static void DeletarVeiculoLeve(
            int Valor
            )
        {
            Context db = new Context();
            db.VeiculosLeve.Remove(GetVeiculoLeve(Valor));
            db.SaveChanges();

>>>>>>> Stashed changes
        }

    }
}
