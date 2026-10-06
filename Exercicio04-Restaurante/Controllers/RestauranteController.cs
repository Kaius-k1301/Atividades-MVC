using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio04.Models;

namespace AtividadesMVC.Kaius.Exercicio04.Controllers;

public class RestauranteController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Cardapio() => View();
    public IActionResult Bebidas() => View();
    public IActionResult Contato() => View();
}
