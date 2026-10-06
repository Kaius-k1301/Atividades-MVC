using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio05.Models;

namespace AtividadesMVC.Kaius.Exercicio05.Controllers;

public class HotelController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Quartos() => View();
    public IActionResult Servicos() => View();
    public IActionResult Contato() => View();
}
