using NSubstitute;
using DotnetMsSqlMRA.Test.Framework;
using DotnetMsSqlMRA.Business.Services;
using DotnetMsSqlMRA.Data.Interfaces;

namespace DotnetMsSqlMRA.Test.Business.StudentServiceSpec
{
    public abstract class UsingStudentServiceSpec : SpecFor<StudentService>
    {
        protected IStudentRepository _studentRepository;

        public override void Context()
        {
            _studentRepository = Substitute.For<IStudentRepository>();
            subject = new StudentService(_studentRepository);

        }

    }
}
