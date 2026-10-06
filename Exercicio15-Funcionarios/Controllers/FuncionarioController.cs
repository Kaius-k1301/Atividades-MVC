using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio15.Models;

namespace AtividadesMVC.Kaius.Exercicio15.Controllers;

public class FuncionarioController : Controller
{
    private static List<Funcionario> CriarFuncionarios() => new()
    {
            new Funcionario { Id = 1, Nome = "Priscila", Cargo = "Coordenador", Departamento = "Engenharia", Salario = 2460.00m, Ativo = true },
            new Funcionario { Id = 2, Nome = "Alan", Cargo = "Assistente", Departamento = "Manutenção", Salario = 2800.00m, Ativo = true },
            new Funcionario { Id = 3, Nome = "Mônica", Cargo = "Técnico", Departamento = "Produção", Salario = 3140.00m, Ativo = true },
            new Funcionario { Id = 4, Nome = "Roberto", Cargo = "Analista", Departamento = "Logística", Salario = 3480.00m, Ativo = false },
            new Funcionario { Id = 5, Nome = "Denise", Cargo = "Supervisor", Departamento = "Engenharia", Salario = 3820.00m, Ativo = true },
            new Funcionario { Id = 6, Nome = "Sérgio", Cargo = "Coordenador", Departamento = "Manutenção", Salario = 4160.00m, Ativo = true },
            new Funcionario { Id = 7, Nome = "Patrícia", Cargo = "Assistente", Departamento = "Produção", Salario = 4500.00m, Ativo = true },
            new Funcionario { Id = 8, Nome = "Márcio", Cargo = "Técnico", Departamento = "Logística", Salario = 4840.00m, Ativo = false },
            new Funcionario { Id = 9, Nome = "Vanessa", Cargo = "Analista", Departamento = "Engenharia", Salario = 5180.00m, Ativo = true },
            new Funcionario { Id = 10, Nome = "Renan", Cargo = "Supervisor", Departamento = "Manutenção", Salario = 5520.00m, Ativo = true },
            new Funcionario { Id = 11, Nome = "Tatiane", Cargo = "Coordenador", Departamento = "Produção", Salario = 5860.00m, Ativo = true },
            new Funcionario { Id = 12, Nome = "Adriano", Cargo = "Assistente", Departamento = "Logística", Salario = 6200.00m, Ativo = false },
            new Funcionario { Id = 13, Nome = "Bruna", Cargo = "Técnico", Departamento = "Engenharia", Salario = 6540.00m, Ativo = true },
            new Funcionario { Id = 14, Nome = "Lucas", Cargo = "Analista", Departamento = "Manutenção", Salario = 6880.00m, Ativo = true },
            new Funcionario { Id = 15, Nome = "Mariana", Cargo = "Supervisor", Departamento = "Produção", Salario = 7220.00m, Ativo = true }
    };
    public IActionResult Index() => View(CriarFuncionarios());
    public IActionResult Ativos() => View(CriarFuncionarios().Where(f => f.Ativo).ToList());
    public IActionResult Inativos() => View(CriarFuncionarios().Where(f => !f.Ativo).ToList());
    public IActionResult Departamento(string nome = "Engenharia")
    {
        ViewBag.Departamento = nome;
        return View(CriarFuncionarios().Where(f => f.Departamento == nome).ToList());
    }
    public IActionResult Dashboard()
    {
        var funcionarios = CriarFuncionarios();
        ViewBag.Total = funcionarios.Count;
        ViewBag.Ativos = funcionarios.Count(f => f.Ativo);
        ViewBag.Inativos = funcionarios.Count(f => !f.Ativo);
        ViewBag.PorDepartamento = funcionarios.GroupBy(f => f.Departamento).ToDictionary(g => g.Key, g => g.Count());
        ViewBag.Media = funcionarios.Average(f => f.Salario);
        ViewBag.Maior = funcionarios.Max(f => f.Salario);
        ViewBag.Menor = funcionarios.Min(f => f.Salario);
        return View();
    }
}
