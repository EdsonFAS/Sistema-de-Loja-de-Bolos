using App_bolo.Context;
using App_bolo.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace App_bolo.Services
{
    public class PedidoService
    {

        private readonly ContextBD _context;

        public PedidoService(ContextBD context)
        {
            _context = context;
        }

        public async Task<List<Pedido>> GetPedidosAsync()
        {
            return await _context.Pedidos
                .Include(p => p.Cliente)
                .Include(p => p.Itens)
                    .ThenInclude(i => i.Produto)
                .ToListAsync();
        }

        public async Task AddPedidoAsync(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
        }
    }
}
