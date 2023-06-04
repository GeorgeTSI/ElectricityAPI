using Dapper;
using System.Data;

namespace ElectricityAPI.Data
{
    public class DapperActions
    {
        public async Task<IEnumerable<T>> DapperQuery<T>(IDbConnection connection, string sql, object? param = null, CommandType? commandType = CommandType.StoredProcedure, IDbTransaction? transaction = null)
        {
            using (IDbConnection conn = connection)
            {
                return await conn.QueryAsync<T>(sql, param, commandType: commandType, transaction: transaction);
            }
        }

    }
}
