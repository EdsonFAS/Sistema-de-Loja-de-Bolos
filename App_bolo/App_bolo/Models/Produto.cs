using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_bolo.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Key]
        [Column("id_prod")]
        public int Id { get; set; }

        [Column("nome_prod")]
        public string Nome { get; set; }

        [Column("descricao_prod")]
        public string Descricao { get; set; }

        [Column("preco_prod")]
        public double Preco { get; set; }

        [Column("peso_prod")]
        public double Peso { get; set; }

    }
}
