using App_bolo.Models;
using Microsoft.EntityFrameworkCore;

namespace App_bolo.Context
{
    public class ContextBD : DbContext
    {
        public ContextBD(DbContextOptions<ContextBD> options):base (options)
        {
         
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItemPedidos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
    }
}
