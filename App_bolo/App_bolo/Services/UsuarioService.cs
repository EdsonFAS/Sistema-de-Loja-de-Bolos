using App_bolo.Context;
using App_bolo.Models;
using System;
using Microsoft.EntityFrameworkCore;

namespace App_bolo.Services
{
    public class UsuarioService
    {

        private readonly ContextBD _context;

        public UsuarioService(ContextBD context)
        {
            _context = context;
        }

        public async Task<Usuario> ValidarLogin(string email, string senha)
            {
                return await _context.Usuarios
                    .FirstOrDefaultAsync(u => u.Email == email && u.Senha == senha);
            }
        
    }
}
