using VendasWeb.Models;

namespace VendasWebMvc.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public decimal SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RegistroVenda> Venda { get; set; } = new List<RegistroVenda>();

        public void AddSales(RegistroVenda rv)
        {
            Venda.Add(rv);
        }

        public void RemoveSales(RegistroVenda rv)
        {
            Venda.Remove(rv);
        }

        public decimal TotalSales(DateTime inicio, DateTime fim)
        {
            return Venda.Where(rv => rv.Data >= inicio && rv.Data <= fim).Sum(rv => rv.Valor);
        }
    }
}
