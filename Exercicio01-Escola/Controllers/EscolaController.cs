using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio01.Models;

namespace AtividadesMVC.Kaius.Exercicio01.Controllers;

public class EscolaController : Controller
{
    public IActionResult Index() => View();
    public IActionResult Cursos() => View();
    public IActionResult Contato() => View();
}
