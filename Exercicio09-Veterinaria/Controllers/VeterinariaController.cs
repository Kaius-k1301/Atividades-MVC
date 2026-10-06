using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio09.Models;

namespace AtividadesMVC.Kaius.Exercicio09.Controllers;

public class VeterinariaController : Controller
{
    private static List<Animal> CriarAnimais() => new()
    {
            new Animal { Id = 1, Nome = "Rocky", Especie = "Cachorro", Idade = 5, Dono = "Talita" },
            new Animal { Id = 2, Nome = "Bolt", Especie = "Gato", Idade = 6, Dono = "Jonas" },
            new Animal { Id = 3, Nome = "Kira", Especie = "Cachorro", Idade = 7, Dono = "Priscila" },
            new Animal { Id = 4, Nome = "Apolo", Especie = "Gato", Idade = 8, Dono = "Alan" },
            new Animal { Id = 5, Nome = "Pandora", Especie = "Coelho", Idade = 9, Dono = "Mônica" },
            new Animal { Id = 6, Nome = "Spike", Especie = "Cachorro", Idade = 10, Dono = "Roberto" },
            new Animal { Id = 7, Nome = "Nero", Especie = "Gato", Idade = 1, Dono = "Denise" },
            new Animal { Id = 8, Nome = "Maia", Especie = "Pássaro", Idade = 2, Dono = "Sérgio" }
    };
    public IActionResult Index() => View(CriarAnimais());
    public IActionResult Cachorros() => View(CriarAnimais().Where(a => a.Especie == "Cachorro").ToList());
    public IActionResult Gatos() => View(CriarAnimais().Where(a => a.Especie == "Gato").ToList());
}
