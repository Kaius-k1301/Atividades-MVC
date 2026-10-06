namespace AtividadesMVC.Kaius.Exercicio13.Models;

public class Pedido
{
    public int Id { get; set; }
    public string Cliente { get; set; } = "";
    public string Produto { get; set; } = "";
    public int Quantidade { get; set; }
    public decimal PrecoUnitario { get; set; }
    public string Status { get; set; } = "";
    public decimal ValorTotal => Quantidade * PrecoUnitario;
}
