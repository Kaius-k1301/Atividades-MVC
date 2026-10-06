using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio03.Models;

namespace AtividadesMVC.Kaius.Exercicio03.Controllers;

public class CinemaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Filmes() => View();
    public IActionResult Ingressos() => View();
}
