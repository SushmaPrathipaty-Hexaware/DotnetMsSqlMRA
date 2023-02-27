using NSubstitute;
using DotnetMsSqlMRA.Test.Framework;
using DotnetMsSqlMRA.Business.Services;
using DotnetMsSqlMRA.Data.Interfaces;

namespace DotnetMsSqlMRA.Test.Business.EmployeeServiceSpec
{
    public abstract class UsingEmployeeServiceSpec : SpecFor<EmployeeService>
    {
        protected IEmployeeRepository _employeeRepository;

        public override void Context()
        {
            _employeeRepository = Substitute.For<IEmployeeRepository>();
            subject = new EmployeeService(_employeeRepository);

        }

    }
}
