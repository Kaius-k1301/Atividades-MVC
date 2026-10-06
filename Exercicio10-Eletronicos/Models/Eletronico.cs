namespace AtividadesMVC.Kaius.Exercicio10.Models;

public class Eletronico
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Marca { get; set; } = "";
    public string Categoria { get; set; } = "";
    public decimal Preco { get; set; }
    public int Estoque { get; set; }
    public string Situacao => Estoque > 0 ? "Disponível" : "Produto esgotado";
}
