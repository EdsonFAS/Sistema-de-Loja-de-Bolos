using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_bolo.Models
{
    [Table("itens_pedido")]
    public class ItemPedido
    {
        [Key]
        [Column("id_item")]
        public int Id { get; set; }

        [Column("id_pedido")]
        public int IdPedido { get; set; }

        [ForeignKey(nameof(IdPedido))]
        public Pedido Pedido { get; set; }

        [Column("id_produto")]
        public int IdProduto { get; set; }

        [ForeignKey(nameof(IdProduto))]
        public Produto Produto { get; set; }

        [Column("quantidade")]
        public int Quantidade { get; set; }
    }
}
