namespace VendasWebMvc.Models
{
    public class Departamento
    {
        public Departamento()
        {
        }

        public Departamento(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedor { get; set; } = new List<Vendedor>();



        public void AddSeller(Vendedor vendedor)
        {
            Vendedor.Add(vendedor);
        }

        public decimal TotalSales(DateTime inicio, DateTime fim)
        {
            return Vendedor.Sum(vendedor => vendedor.TotalVendas(inicio, fim));
        }
    }
}
