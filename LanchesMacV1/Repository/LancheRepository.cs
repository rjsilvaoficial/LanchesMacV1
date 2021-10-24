using LanchesMacV1.Context;
using LanchesMacV1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanchesMacV1.Repository
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(atb => atb.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(atb => atb.IsLanchePreferido);

        public Lanche GetLancheById(int lancheId)
        {
            var lancheBuscado = _context.Lanches.FirstOrDefault(objeto => objeto.LancheId == lancheId);

            return lancheBuscado;
        }
    }
}
