using ElectricityAPI.Models;

namespace ElectricityAPI.Repositories
{
    public interface IElectricityRepository
    {
        Task<IEnumerable<ElectricityModel>> GetElectricityData();
    }
}
