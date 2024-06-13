using VendasWebMvc.Models.Enums;

namespace VendasWeb.Models
{
    public class RegistroVenda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public EStatusVendas Status { get; set; }
    }
}
