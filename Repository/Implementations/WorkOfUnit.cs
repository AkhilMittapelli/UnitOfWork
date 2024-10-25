
using UnitOfWork.Data;

namespace UnitOfWork.Repository.Implementations
{
    public class WorkOfUnit : IUnitOfWork
    {
        private readonly StudentContext studentContext;
        public IStudentService StudentService { get; private set; }
        public WorkOfUnit(StudentContext _studentContext)
        {
            studentContext = _studentContext;

            StudentService = new StudentService(studentContext);


        }
       
    }
}
