using App_bolo.Context;
using App_bolo.Models;
using Microsoft.EntityFrameworkCore;

namespace App_bolo.Services
{
    public class ClienteService
    {
        private readonly ContextBD _context;

        public ClienteService(ContextBD context)
        {

            _context = context;
        }

        public async Task<List<Clientes>> GetClientesAsync()
        {
            var clientes = await _context.Clientes.ToListAsync();
            return clientes;
        }

        public async Task<Clientes?> GetClienteByIdAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            return cliente;
        }

        public async Task AddClienteAsync(Clientes cliente)
        {
            _context.Clientes.Add(cliente);
            await _context.SaveChangesAsync();

        }

        public async Task UpdateClienteAsync(Clientes cliente)
        {
            var clienteLocal = await _context.Clientes.FindAsync(cliente.Id_cli);
            if (clienteLocal != null)
            {
                _context.Entry(clienteLocal).CurrentValues.SetValues(cliente);
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteClienteAsync(int id)
        {
            var cliente = await _context.Clientes.FindAsync(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                await _context.SaveChangesAsync();
            }
        }
    }
}
