namespace UnitOfWork.Repository
{
    public interface IUnitOfWork
    {
        IStudentService StudentService { get; }

        
    }
}
