using System.Collections.Generic;
using System.Threading.Tasks;

namespace Projeto
{
    public interface IDataAccess
    {
        Task<List<T>> loadData<T, U>(string sql, U parameters, string connectionString);
        Task saveData<T>(string sql, T parameters, string connectionString);
    }
}