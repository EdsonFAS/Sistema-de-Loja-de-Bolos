using App_bolo.Context;

using App_bolo.Models;
using Microsoft.EntityFrameworkCore;
using System;

public class ProdutoService
{
    private readonly ContextBD _context;

    public ProdutoService(ContextBD context)
    {

        _context = context;
    }

    public async Task<List<Produto>> GetProdutosAsync()
    {
        return await _context.Produto.ToListAsync();
    }

    public async Task AddProdutoAsync(Produto produto)
    {
        _context.Produto.Add(produto);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateProdutoAsync(Produto produto)
    {
        var produtoExistente = await _context.Produto.FindAsync(produto.Id);
        if (produtoExistente is not null)
        {
            produtoExistente.Nome = produto.Nome;
            produtoExistente.Descricao = produto.Descricao;
            produtoExistente.Preco = produto.Preco;
            produtoExistente.Peso = produto.Peso;

            await _context.SaveChangesAsync();
        }
    }

    public async Task DeleteProdutoAsync(int id)
    {
        var produto = await _context.Produto.FindAsync(id);
        if (produto is not null)
        {
            _context.Produto.Remove(produto);
            await _context.SaveChangesAsync();
        }
    }
}