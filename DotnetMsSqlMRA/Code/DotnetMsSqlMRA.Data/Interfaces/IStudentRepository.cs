using DotnetMsSqlMRA.Entities.Entities;


namespace DotnetMsSqlMRA.Data.Interfaces
{
    public interface IStudentRepository : IGetById<Student>, IGetAll<Student>, ISave<Student>, IUpdate<Student>, IDelete<int>
    {
    }
}
