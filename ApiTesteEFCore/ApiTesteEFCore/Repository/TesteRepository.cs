using ApiTesteEFCore.DB;
using ApiTesteEFCore.Models;
using ApiTesteEFCore.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTesteEFCore.Repository
{
    public class TesteRepository : ITesteRepository
    {
        private readonly ApplicationDbContext _context;
        public TesteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Teste> GetAll()
        {
            return _context.Teste.ToList();
        }
    }
}
