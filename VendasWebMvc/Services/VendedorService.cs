using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Data;
using VendasWebMvc.Models;

namespace VendasWebMvc.Services
{
    public class VendedorService
    {
        private readonly VendasWebMvcContext _context;
        public VendedorService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
        public void Insert(Vendedor v)
        {
            
            _context.Add(v);
            _context.SaveChanges();
        }
        public Vendedor FindById (int id) 
        {
            return _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefault(obj => obj.Id == id);
        }
        public void Remove(int id)
        {
            var obj = _context.Vendedor.Find(id);
            _context.Vendedor.Remove(obj);
            _context.SaveChanges();
        }
    }
}
