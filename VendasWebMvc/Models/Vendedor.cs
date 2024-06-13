namespace VendasWebMvc.Models;

public class Vendedor
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public decimal SalarioBase { get; set; }
    public Departamento Departamento { get; set; }
    public ICollection<RegistroVenda> Vendas { get; set; } = new List<RegistroVenda>();

    public Vendedor()
    {
    }

    public Vendedor(int id, string nome, string email, DateTime dataNascimento, decimal salarioBase, Departamento departamento)
    {
        Id = id;
        Nome = nome;
        Email = email;
        DataNascimento = dataNascimento;
        SalarioBase = salarioBase;
        Departamento = departamento;
    }

    public void AddVendas(RegistroVenda rv)
    {
        Vendas.Add(rv);
    }

    public void RemoveVendas(RegistroVenda rv)
    {
        Vendas.Remove(rv);
    }

    public decimal TotalVendas(DateTime inicio, DateTime fim)
    {
        return Vendas.Where(rv => rv.Data >= inicio && rv.Data <= fim).Sum(rv => rv.Valor);
    }
}
