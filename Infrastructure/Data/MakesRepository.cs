using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class MakesRepository : IMakesRepository
    {
        private readonly StoreContext _context;
        private readonly IMapper _mapper;
        public MakesRepository(StoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<Make>> GetMakesAsync()
        {
            return await _context.Make.Include(m => m.Models).ToListAsync();
        }

        public async Task<Make> GetMakesByIdAsync(int id)
        {
            return await _context.Make.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}