using System.Collections.Generic;
using System.Linq;
using Repository;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Model
{
    public class LocacaoVeiculo
    {
        [Key] // Data Annotations - Main key
        public int Id { get; set; }
        [ForeignKey("locacoes")] // Data Annotations - Foreign Key
        public int IdLocacao { get; set; }
        public virtual Model.Locacao Locacao { get; set; }
        [ForeignKey("veiculos")] // Data Annotations - Foreign Key
        public int IdVeiculo { get; set; }
        public virtual Model.Veiculo Veiculo { get; set; }
        public static List<LocacaoVeiculo> GetLocacoesByVeiculo(int IdVeiculo)
        {
            var db = new Context();
            return (from locacao in db.LocacaoVeiculo
                    where locacao.IdVeiculo == IdVeiculo
                    select locacao).ToList();
        }

    }
}