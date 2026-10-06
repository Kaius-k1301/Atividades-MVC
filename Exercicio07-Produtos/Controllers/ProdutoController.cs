using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio07.Models;

namespace AtividadesMVC.Kaius.Exercicio07.Controllers;

public class ProdutoController : Controller
{
    private static List<Produto> CriarProdutos() => new()
    {
            new Produto { Id = 1, Nome = "Jogo de chaves", Categoria = "Informática", Estoque = 7, Preco = 26.50m },
            new Produto { Id = 2, Nome = "Multímetro", Categoria = "Papelaria", Estoque = 8, Preco = 37.50m },
            new Produto { Id = 3, Nome = "Furadeira", Categoria = "Casa", Estoque = 0, Preco = 48.50m },
            new Produto { Id = 4, Nome = "Trena laser", Categoria = "Acessórios", Estoque = 10, Preco = 59.50m },
            new Produto { Id = 5, Nome = "Caixa de ferramentas", Categoria = "Informática", Estoque = 11, Preco = 70.50m },
            new Produto { Id = 6, Nome = "Lanterna tática", Categoria = "Papelaria", Estoque = 12, Preco = 81.50m },
            new Produto { Id = 7, Nome = "Alicate universal", Categoria = "Casa", Estoque = 13, Preco = 92.50m },
            new Produto { Id = 8, Nome = "Parafusadeira", Categoria = "Acessórios", Estoque = 0, Preco = 103.50m },
            new Produto { Id = 9, Nome = "Nível digital", Categoria = "Informática", Estoque = 15, Preco = 114.50m },
            new Produto { Id = 10, Nome = "Capacete", Categoria = "Papelaria", Estoque = 16, Preco = 125.50m }
    };
    public IActionResult Index() => View(CriarProdutos());
    public IActionResult Disponiveis() => View(CriarProdutos().Where(p => p.Estoque > 0).ToList());
}
