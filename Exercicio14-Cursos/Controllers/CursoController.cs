using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio14.Models;

namespace AtividadesMVC.Kaius.Exercicio14.Controllers;

public class CursoController : Controller
{
    private static List<Curso> CriarCursos() => new()
    {
            new Curso { Id = 1, Nome = "CLP Básico", CargaHoraria = 20, Modalidade = "Presencial", Vagas = 5, Valor = 240.00m },
            new Curso { Id = 2, Nome = "Instalações Elétricas", CargaHoraria = 40, Modalidade = "Presencial", Vagas = 7, Valor = 295.00m },
            new Curso { Id = 3, Nome = "Manutenção Mecânica", CargaHoraria = 60, Modalidade = "Online", Vagas = 9, Valor = 350.00m },
            new Curso { Id = 4, Nome = "Redes de Computadores", CargaHoraria = 80, Modalidade = "Presencial", Vagas = 0, Valor = 405.00m },
            new Curso { Id = 5, Nome = "Soldagem", CargaHoraria = 100, Modalidade = "Presencial", Vagas = 13, Valor = 460.00m },
            new Curso { Id = 6, Nome = "Operador de CNC", CargaHoraria = 20, Modalidade = "Online", Vagas = 15, Valor = 515.00m },
            new Curso { Id = 7, Nome = "Desenho CAD", CargaHoraria = 40, Modalidade = "Presencial", Vagas = 17, Valor = 570.00m },
            new Curso { Id = 8, Nome = "Metrologia", CargaHoraria = 60, Modalidade = "Presencial", Vagas = 19, Valor = 625.00m },
            new Curso { Id = 9, Nome = "Lean Manufacturing", CargaHoraria = 80, Modalidade = "Online", Vagas = 0, Valor = 680.00m },
            new Curso { Id = 10, Nome = "Robótica Industrial", CargaHoraria = 100, Modalidade = "Presencial", Vagas = 23, Valor = 735.00m }
    };
    public IActionResult Index()
    {
        var cursos = CriarCursos();
        ViewBag.Total = cursos.Count;
        ViewBag.Disponiveis = cursos.Count(c => c.Vagas > 0);
        ViewBag.Lotados = cursos.Count(c => c.Vagas == 0);
        ViewBag.Online = cursos.Count(c => c.Modalidade == "Online");
        ViewBag.Presenciais = cursos.Count(c => c.Modalidade == "Presencial");
        return View(cursos);
    }
    public IActionResult Disponiveis() => View(CriarCursos().Where(c => c.Vagas > 0).ToList());
    public IActionResult Online() => View(CriarCursos().Where(c => c.Modalidade == "Online").ToList());
    public IActionResult Presenciais() => View(CriarCursos().Where(c => c.Modalidade == "Presencial").ToList());
    public IActionResult Resumo()
    {
        var cursos = CriarCursos();
        ViewBag.Total = cursos.Count;
        ViewBag.Disponiveis = cursos.Count(c => c.Vagas > 0);
        ViewBag.Lotados = cursos.Count(c => c.Vagas == 0);
        ViewBag.Online = cursos.Count(c => c.Modalidade == "Online");
        ViewBag.Presenciais = cursos.Count(c => c.Modalidade == "Presencial");
        return View();
    }
}
