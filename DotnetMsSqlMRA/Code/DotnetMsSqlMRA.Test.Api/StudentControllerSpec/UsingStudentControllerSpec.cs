using NSubstitute;
using DotnetMsSqlMRA.Test.Framework;
using DotnetMsSqlMRA.Api.Controllers;
using DotnetMsSqlMRA.Business.Interfaces;


namespace DotnetMsSqlMRA.Test.Api.StudentControllerSpec
{
    public abstract class UsingStudentControllerSpec : SpecFor<StudentController>
    {
        protected IStudentService _studentService;

        public override void Context()
        {
            _studentService = Substitute.For<IStudentService>();
            subject = new StudentController(_studentService);

        }

    }
}
