using ElectricityAPI.Data;
using ElectricityAPI.Models;

namespace ElectricityAPI.Repositories
{
    public class ElectricityRepository: IElectricityRepository
    {
        private readonly Connections _conn;

        public ElectricityRepository(Connections connections)
        {
            _conn = connections;
        }

       

        public async Task<IEnumerable<ElectricityModel>> GetElectricityData()
        {
            string sql = "Get_ElectricityData";
            try
            {
                return await new DapperActions().DapperQuery<ElectricityModel>(_conn.LocalConnection, sql);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
