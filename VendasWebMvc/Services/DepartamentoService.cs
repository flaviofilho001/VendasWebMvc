using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class DepartamentoService
    {
        private readonly VendasWebMvcContext _context;

        public DepartamentoService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Departamento> FindAll()
        {
            return _context.Departamento.OrderBy(x => x.Nome).ToList();
        }
    }
}
