using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio06.Models;

namespace AtividadesMVC.Kaius.Exercicio06.Controllers;

public class AlunoController : Controller
{
    private static List<Aluno> CriarAlunos() => new()
    {
            new Aluno { Id = 1, Nome = "Nicolas", Idade = 20, Curso = "Automação" },
            new Aluno { Id = 2, Nome = "Débora", Idade = 21, Curso = "Redes" },
            new Aluno { Id = 3, Nome = "Fernando", Idade = 22, Curso = "Mecatrônica" },
            new Aluno { Id = 4, Nome = "Rita", Idade = 23, Curso = "Usinagem" },
            new Aluno { Id = 5, Nome = "Cristiano", Idade = 16, Curso = "Manutenção Industrial" },
            new Aluno { Id = 6, Nome = "Talita", Idade = 17, Curso = "Automação" },
            new Aluno { Id = 7, Nome = "Jonas", Idade = 18, Curso = "Redes" },
            new Aluno { Id = 8, Nome = "Priscila", Idade = 19, Curso = "Mecatrônica" }
    };

    public IActionResult Index() => View(CriarAlunos());

    public IActionResult Detalhes(int id)
    {
        var aluno = CriarAlunos().FirstOrDefault(a => a.Id == id);
        if (aluno == null) return NotFound();
        return View(aluno);
    }
}
