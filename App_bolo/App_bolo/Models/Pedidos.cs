using System.ComponentModel.DataAnnotations.Schema;

namespace App_bolo.Models
{
    [Table("Pedido")]
    public class Pedidos
    {
        [Column("id_ped")]
        public int Id_ped { get; set; }
    }
}
