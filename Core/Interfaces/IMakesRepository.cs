using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public interface IMakesRepository
    {
        Task<Make> GetMakesByIdAsync(int id);
        Task<IReadOnlyList<Make>> GetMakesAsync();
    }
}