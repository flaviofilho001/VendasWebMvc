using VendasWebMvc.Models.Enums;

namespace VendasWebMvc.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public EStatusVendas Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistroVenda() { }

        public RegistroVenda(int id, DateTime data, decimal valor, EStatusVendas status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Valor = valor;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
