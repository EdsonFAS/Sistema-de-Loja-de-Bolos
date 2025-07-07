using System.ComponentModel.DataAnnotations.Schema;

namespace App_bolo.Models
{
    [Table("Cliente")]
    public class Clientes
    {
        [Column("id_cli")]
        public int Id_cli { get; set; }

        [Column("nome_cli")]
        public string Nome_cli { get; set; }

        [Column("email_cli")]
        public string Email_cli {  get; set; }

        [Column("endereco_cli")]
        public string Endereco_Cli { get; set; }

        [Column("data_nasc_cli")]
        public DateTime Data_nasc_cli { get;set; }
    }
}
