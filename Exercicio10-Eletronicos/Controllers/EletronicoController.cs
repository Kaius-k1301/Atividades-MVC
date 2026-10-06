using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio10.Models;

namespace AtividadesMVC.Kaius.Exercicio10.Controllers;

public class EletronicoController : Controller
{
    private static List<Eletronico> CriarEletronicos() => new()
    {
            new Eletronico { Id = 1, Nome = "Notebook Forge", Marca = "Core", Categoria = "Computadores", Preco = 220.00m, Estoque = 2 },
            new Eletronico { Id = 2, Nome = "Celular Titan", Marca = "Orbit", Categoria = "Celulares", Preco = 365.00m, Estoque = 3 },
            new Eletronico { Id = 3, Nome = "Monitor Ultra", Marca = "Nexa", Categoria = "Áudio", Preco = 510.00m, Estoque = 4 },
            new Eletronico { Id = 4, Nome = "Teclado Mech", Marca = "Vox", Categoria = "Acessórios", Preco = 655.00m, Estoque = 0 },
            new Eletronico { Id = 5, Nome = "Mouse Pro", Marca = "Lumina", Categoria = "Computadores", Preco = 800.00m, Estoque = 6 },
            new Eletronico { Id = 6, Nome = "Roteador Mesh", Marca = "Core", Categoria = "Celulares", Preco = 945.00m, Estoque = 7 },
            new Eletronico { Id = 7, Nome = "Câmera Action", Marca = "Orbit", Categoria = "Áudio", Preco = 1090.00m, Estoque = 8 },
            new Eletronico { Id = 8, Nome = "Drone Mini", Marca = "Nexa", Categoria = "Acessórios", Preco = 1235.00m, Estoque = 2 },
            new Eletronico { Id = 9, Nome = "Console Play", Marca = "Vox", Categoria = "Computadores", Preco = 1380.00m, Estoque = 3 },
            new Eletronico { Id = 10, Nome = "Headset Core", Marca = "Lumina", Categoria = "Celulares", Preco = 1525.00m, Estoque = 4 },
            new Eletronico { Id = 11, Nome = "SSD Drive", Marca = "Core", Categoria = "Áudio", Preco = 1670.00m, Estoque = 0 },
            new Eletronico { Id = 12, Nome = "Impressora Laser", Marca = "Orbit", Categoria = "Acessórios", Preco = 1815.00m, Estoque = 6 }
    };
    public IActionResult Index() => View(CriarEletronicos());
    public IActionResult EmEstoque() => View(CriarEletronicos().Where(e => e.Estoque > 0).ToList());
    public IActionResult Categoria(string categoria = "Computadores")
    {
        ViewBag.Categoria = categoria;
        return View(CriarEletronicos().Where(e => e.Categoria == categoria).ToList());
    }
    public IActionResult Promocoes() => View(CriarEletronicos().Where(e => e.Preco < 1300m).ToList());
}
