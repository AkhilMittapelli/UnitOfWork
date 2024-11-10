namespace UnitOfWork.Repository
{
    public interface All

    { 
        IStudentService StudentService { get; }

        IMarks  MarkService { get; }
    }
}
