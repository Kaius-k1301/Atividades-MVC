namespace AtividadesMVC.Kaius.Exercicio07.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "";
    public int Estoque { get; set; }
    public decimal Preco { get; set; }
    public string Situacao => Estoque == 0 ? "Produto esgotado" : "Disponível";
}
