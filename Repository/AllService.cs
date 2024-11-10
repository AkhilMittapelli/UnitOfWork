namespace UnitOfWork.Repository
{
    public class AllService : All
    {
        public IStudentService StudentService { get; }
        public IMarks MarkService { get; }

        public AllService(IStudentService   student, IMarks mark)
        {
            StudentService = student;
            MarkService = mark;


        }
    }

}
