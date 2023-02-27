using NSubstitute;
using DotnetMsSqlMRA.Test.Framework;
using DotnetMsSqlMRA.Api.Controllers;
using DotnetMsSqlMRA.Business.Interfaces;


namespace DotnetMsSqlMRA.Test.Api.EmployeeControllerSpec
{
    public abstract class UsingEmployeeControllerSpec : SpecFor<EmployeeController>
    {
        protected IEmployeeService _employeeService;

        public override void Context()
        {
            _employeeService = Substitute.For<IEmployeeService>();
            subject = new EmployeeController(_employeeService);

        }

    }
}
