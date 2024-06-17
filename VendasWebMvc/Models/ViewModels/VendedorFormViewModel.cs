namespace VendasWebMvc.Models.ViewModels
{
    public class VendedorFormViewModel
    {
        public Vendedor Vendedor { get; set; }
        public ICollection<Departamento> Departamentoes{ get; set; }
    }
}
