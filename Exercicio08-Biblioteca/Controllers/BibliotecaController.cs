using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio08.Models;

namespace AtividadesMVC.Kaius.Exercicio08.Controllers;

public class BibliotecaController : Controller
{
    private static List<Livro> CriarLivros() => new()
    {
            new Livro { Id = 1, Titulo = "Máquinas e Ideias", Autor = "T. Prado", Ano = 2012, Disponivel = true },
            new Livro { Id = 2, Titulo = "Redes sem Mistério", Autor = "L. Monteiro", Ano = 2013, Disponivel = false },
            new Livro { Id = 3, Titulo = "Oficina Inteligente", Autor = "C. Duarte", Ano = 2014, Disponivel = true },
            new Livro { Id = 4, Titulo = "Guia da Automação", Autor = "R. Nascimento", Ano = 2015, Disponivel = true },
            new Livro { Id = 5, Titulo = "Projetos com Sensores", Autor = "M. Alves", Ano = 2016, Disponivel = false },
            new Livro { Id = 6, Titulo = "Eletricidade Prática", Autor = "T. Prado", Ano = 2017, Disponivel = true },
            new Livro { Id = 7, Titulo = "Manutenção Segura", Autor = "L. Monteiro", Ano = 2018, Disponivel = true },
            new Livro { Id = 8, Titulo = "Lógica de Controle", Autor = "C. Duarte", Ano = 2019, Disponivel = false },
            new Livro { Id = 9, Titulo = "Produção Enxuta", Autor = "R. Nascimento", Ano = 2020, Disponivel = true },
            new Livro { Id = 10, Titulo = "Robótica Aplicada", Autor = "M. Alves", Ano = 2021, Disponivel = true }
    };
    public IActionResult Index() => View(CriarLivros());
    public IActionResult Disponiveis() => View(CriarLivros().Where(l => l.Disponivel).ToList());
}
