using System.Collections.Generic;

namespace DotnetMsSqlMRA.Data.Interfaces
{
    public interface IGetAll<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
