using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio11.Models;

namespace AtividadesMVC.Kaius.Exercicio11.Controllers;

public class AlunoController : Controller
{
    private static List<Aluno> CriarAlunos() => new()
    {
            new Aluno { Id = 1, Nome = "Fernando", Curso = "Automação", Nota1 = 9.00, Nota2 = 8.50, Nota3 = 7.50 },
            new Aluno { Id = 2, Nome = "Rita", Curso = "Redes", Nota1 = 4.00, Nota2 = 4.00, Nota3 = 4.50 },
            new Aluno { Id = 3, Nome = "Cristiano", Curso = "Mecatrônica", Nota1 = 5.50, Nota2 = 6.00, Nota3 = 5.00 },
            new Aluno { Id = 4, Nome = "Talita", Curso = "Usinagem", Nota1 = 2.50, Nota2 = 3.00, Nota3 = 3.50 },
            new Aluno { Id = 5, Nome = "Jonas", Curso = "Manutenção Industrial", Nota1 = 7.00, Nota2 = 7.50, Nota3 = 6.50 },
            new Aluno { Id = 6, Nome = "Priscila", Curso = "Automação", Nota1 = 4.50, Nota2 = 5.00, Nota3 = 5.50 },
            new Aluno { Id = 7, Nome = "Alan", Curso = "Redes", Nota1 = 8.00, Nota2 = 7.00, Nota3 = 9.00 },
            new Aluno { Id = 8, Nome = "Mônica", Curso = "Mecatrônica", Nota1 = 6.00, Nota2 = 6.50, Nota3 = 7.00 },
            new Aluno { Id = 9, Nome = "Roberto", Curso = "Usinagem", Nota1 = 5.00, Nota2 = 4.50, Nota3 = 5.50 },
            new Aluno { Id = 10, Nome = "Denise", Curso = "Manutenção Industrial", Nota1 = 3.00, Nota2 = 3.50, Nota3 = 2.00 }
    };
    public IActionResult Index() => View(CriarAlunos());
    public IActionResult Aprovados() => View(CriarAlunos().Where(a => a.Media >= 6).ToList());
    public IActionResult Recuperacao() => View(CriarAlunos().Where(a => a.Media >= 4 && a.Media < 6).ToList());
    public IActionResult Reprovados() => View(CriarAlunos().Where(a => a.Media < 4).ToList());
}
