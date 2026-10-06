namespace AtividadesMVC.Kaius.Exercicio15.Models;

public class Funcionario
{
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Cargo { get; set; } = "";
    public string Departamento { get; set; } = "";
    public decimal Salario { get; set; }
    public bool Ativo { get; set; }
    public string Situacao => Ativo ? "Funcionário ativo" : "Funcionário desligado";
    public string FaixaSalarial
    {
        get
        {
            if (Salario < 2500) return "Faixa 1";
            if (Salario <= 5000) return "Faixa 2";
            return "Faixa 3";
        }
    }
}
