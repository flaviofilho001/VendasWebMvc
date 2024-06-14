﻿using VendasWebMvc.Data;
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
            v.Departamento = _context.Departamento.First();
            _context.Add(v);
            _context.SaveChanges();
        }
    }
}
