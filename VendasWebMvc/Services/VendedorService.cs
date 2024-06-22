using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Data;
using VendasWebMvc.Models;
using VendasWebMvc.Services.Exceptions;

namespace VendasWebMvc.Services
{
    public class VendedorService
    {
        private readonly VendasWebMvcContext _context;
        public VendedorService(VendasWebMvcContext context)
        {
            _context = context;
        }

        public async Task<List<Vendedor>> FindAllAsync()
        {
            return await _context.Vendedor.ToListAsync();
        }
        public async Task InsertAsync(Vendedor v)
        {
            
            _context.Add(v);
            await _context.SaveChangesAsync();
        }
        public async Task<Vendedor> FindByIdAsync (int id) 
        {
            return await _context.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }
        public async Task RemoveAsync(int id)
        {
            try
            {
            var obj = await _context.Vendedor.FindAsync(id);
            _context.Vendedor.Remove(obj);
            await _context.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message);
            }
        }

        public async Task UpdateAsync(Vendedor obj) 
        {
            bool hasAny = await _context.Vendedor.AnyAsync(x => x.Id == obj.Id);
            if (!hasAny) 
            {
                throw new NotFoundException("Id não encontrado"); 
            }
            try
            {
                _context.Update(obj);
                await _context.SaveChangesAsync();
            }
            catch (DbConcurrencyException e) 
            {
                throw new DbConcurrencyException(e.Message);
            }
        }
    }
}
