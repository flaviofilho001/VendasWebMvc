using System.ComponentModel.DataAnnotations;

namespace VendasWebMvc.Models;

public class Vendedor
{
    public int Id { get; set; }
    [Required(ErrorMessage ="{0} é requerido")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "{0} não é possível, insira um nome entre {2} e {1} caracteres")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "{0} é requerido")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; }
    [Required(ErrorMessage = "{0} é requerido")]
    [Display(Name = "Data de Nascimento")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }
    [Required(ErrorMessage = "{0} é requerido")]
    [Range(100, 50000, ErrorMessage = "{0} não é possível, insira um entre {1} e {2}")]
    [Display(Name = "Salário Base")]
    [DisplayFormat(DataFormatString ="{0:F2}")]
    public decimal SalarioBase { get; set; }
    public Departamento Departamento { get; set; }
    public int DepartamentoId { get; set; }
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
