using System.Collections.Generic;
using System.Threading.Tasks;
using Core.Entities;

namespace Core.Interfaces
{
    public class IVehiclesRepository
    {
        Task<Vehicle> GetVehicle (int id);
    }
}