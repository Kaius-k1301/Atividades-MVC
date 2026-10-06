using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio02.Models;

namespace AtividadesMVC.Kaius.Exercicio02.Controllers;

public class AcademiaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Musculacao() => View();
    public IActionResult Cardio() => View();
    public IActionResult Planos() => View();
}
