using Microsoft.EntityFrameworkCore;
using VendasWebMvc.Models;

namespace VendasWebMvc.Data
{
    public class VendasWebMvcContext : DbContext
    {
        public VendasWebMvcContext (DbContextOptions<VendasWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Departamento> Departamento { get; set; } = default!;
        public DbSet<Vendedor> Vendedor { get; set; } = default!;
        public DbSet<RegistroVenda> RegistroVendas { get; set; } = default!;
    }
}
