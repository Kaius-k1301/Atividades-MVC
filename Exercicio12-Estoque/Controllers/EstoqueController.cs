using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio12.Models;

namespace AtividadesMVC.Kaius.Exercicio12.Controllers;

public class EstoqueController : Controller
{
    private static List<Produto> CriarProdutos() => new()
    {
            new Produto { Id = 1, Nome = "Parafuso M8", Categoria = "Consumo", Estoque = 1, EstoqueMinimo = 3, Preco = 10.50m },
            new Produto { Id = 2, Nome = "Porca", Categoria = "Equipamento", Estoque = 8, EstoqueMinimo = 4, Preco = 18.50m },
            new Produto { Id = 3, Nome = "Arruela", Categoria = "Material", Estoque = 0, EstoqueMinimo = 5, Preco = 26.50m },
            new Produto { Id = 4, Nome = "Rolamento", Categoria = "Consumo", Estoque = 4, EstoqueMinimo = 3, Preco = 34.50m },
            new Produto { Id = 5, Nome = "Correia", Categoria = "Equipamento", Estoque = 14, EstoqueMinimo = 4, Preco = 42.50m },
            new Produto { Id = 6, Nome = "Óleo lubrificante", Categoria = "Material", Estoque = 3, EstoqueMinimo = 5, Preco = 50.50m },
            new Produto { Id = 7, Nome = "Broca", Categoria = "Consumo", Estoque = 9, EstoqueMinimo = 3, Preco = 58.50m },
            new Produto { Id = 8, Nome = "Disco de corte", Categoria = "Equipamento", Estoque = 0, EstoqueMinimo = 4, Preco = 66.50m },
            new Produto { Id = 9, Nome = "Eletrodo", Categoria = "Material", Estoque = 6, EstoqueMinimo = 5, Preco = 74.50m },
            new Produto { Id = 10, Nome = "Cabo PP", Categoria = "Consumo", Estoque = 11, EstoqueMinimo = 3, Preco = 82.50m },
            new Produto { Id = 11, Nome = "Conector", Categoria = "Equipamento", Estoque = 2, EstoqueMinimo = 4, Preco = 90.50m },
            new Produto { Id = 12, Nome = "Sensor", Categoria = "Material", Estoque = 0, EstoqueMinimo = 5, Preco = 98.50m },
            new Produto { Id = 13, Nome = "Relé", Categoria = "Consumo", Estoque = 2, EstoqueMinimo = 3, Preco = 106.50m },
            new Produto { Id = 14, Nome = "Fusível", Categoria = "Equipamento", Estoque = 5, EstoqueMinimo = 4, Preco = 114.50m },
            new Produto { Id = 15, Nome = "Chave fim de curso", Categoria = "Material", Estoque = 12, EstoqueMinimo = 5, Preco = 122.50m }
    };
    public IActionResult Index() => View(CriarProdutos());
    public IActionResult Baixo() => View(CriarProdutos().Where(p => p.Estoque > 0 && p.Estoque <= p.EstoqueMinimo).ToList());
    public IActionResult Esgotados() => View(CriarProdutos().Where(p => p.Estoque == 0).ToList());
    public IActionResult Alertas() => View(CriarProdutos().Where(p => p.Estoque <= p.EstoqueMinimo).ToList());
}
