using DotnetMsSqlMRA.Entities.Entities;


namespace DotnetMsSqlMRA.Data.Interfaces
{
    public interface IEmployeeRepository : IGetById<Employee>, IGetAll<Employee>, ISave<Employee>, IUpdate<Employee>, IDelete<int>
    {
    }
}
