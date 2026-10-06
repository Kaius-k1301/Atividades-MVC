using Microsoft.AspNetCore.Mvc;
using AtividadesMVC.Kaius.Exercicio13.Models;

namespace AtividadesMVC.Kaius.Exercicio13.Controllers;

public class PedidoController : Controller
{
    private static List<Pedido> CriarPedidos() => new()
    {
            new Pedido { Id = 1, Cliente = "Cristiano", Produto = "X-Bacon", Quantidade = 1, PrecoUnitario = 12.00m, Status = "Recebido" },
            new Pedido { Id = 2, Cliente = "Talita", Produto = "Hot dog", Quantidade = 2, PrecoUnitario = 14.25m, Status = "Em preparo" },
            new Pedido { Id = 3, Cliente = "Jonas", Produto = "Batata com cheddar", Quantidade = 3, PrecoUnitario = 16.50m, Status = "Pronto" },
            new Pedido { Id = 4, Cliente = "Priscila", Produto = "Refrigerante", Quantidade = 1, PrecoUnitario = 18.75m, Status = "Entregue" },
            new Pedido { Id = 5, Cliente = "Alan", Produto = "X-Frango", Quantidade = 2, PrecoUnitario = 21.00m, Status = "Recebido" },
            new Pedido { Id = 6, Cliente = "Mônica", Produto = "Onion rings", Quantidade = 3, PrecoUnitario = 23.25m, Status = "Em preparo" },
            new Pedido { Id = 7, Cliente = "Roberto", Produto = "Suco de laranja", Quantidade = 1, PrecoUnitario = 25.50m, Status = "Pronto" },
            new Pedido { Id = 8, Cliente = "Denise", Produto = "Misto quente", Quantidade = 2, PrecoUnitario = 27.75m, Status = "Entregue" },
            new Pedido { Id = 9, Cliente = "Sérgio", Produto = "X-Egg", Quantidade = 3, PrecoUnitario = 30.00m, Status = "Recebido" },
            new Pedido { Id = 10, Cliente = "Patrícia", Produto = "Milk-shake de chocolate", Quantidade = 1, PrecoUnitario = 32.25m, Status = "Em preparo" }
    };
    public IActionResult Index() => View(CriarPedidos());
    public IActionResult EmPreparo() => View(CriarPedidos().Where(p => p.Status == "Em preparo").ToList());
    public IActionResult Prontos() => View(CriarPedidos().Where(p => p.Status == "Pronto").ToList());
    public IActionResult Entregues() => View(CriarPedidos().Where(p => p.Status == "Entregue").ToList());
    public IActionResult Resumo()
    {
        var pedidos = CriarPedidos();
        ViewBag.TotalPedidos = pedidos.Count;
        ViewBag.ValorTotal = pedidos.Sum(p => p.ValorTotal);
        ViewBag.PorStatus = pedidos.GroupBy(p => p.Status).ToDictionary(g => g.Key, g => g.Count());
        return View();
    }
}
