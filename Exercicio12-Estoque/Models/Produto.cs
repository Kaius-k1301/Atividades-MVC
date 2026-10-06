namespace AtividadesMVC.Kaius.Exercicio12.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Categoria { get; set; } = "";
    public int Estoque { get; set; }
    public int EstoqueMinimo { get; set; }
    public decimal Preco { get; set; }
    public string Situacao
    {
        get
        {
            if (Estoque == 0) return "ESGOTADO";
            if (Estoque <= EstoqueMinimo) return "ESTOQUE BAIXO";
            return "ESTOQUE NORMAL";
        }
    }
}
