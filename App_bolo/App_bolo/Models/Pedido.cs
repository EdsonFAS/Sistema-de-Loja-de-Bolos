using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_bolo.Models
{
    [Table("pedido")]
    public class Pedido
    {
        [Key]
        [Column("id_ped")]
        public int Id { get; set; }

        [Column("data_ped")]
        public DateTime DataPedido { get; set; } = DateTime.Now;

        [Column("id_cliente")]
        public int IdCliente { get; set; }

        [ForeignKey("IdCliente")]
        public Clientes? Cliente { get; set; }

        public List<ItemPedido> Itens { get; set; } = new();
    }
}
